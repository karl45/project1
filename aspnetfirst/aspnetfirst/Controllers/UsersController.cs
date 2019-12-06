using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspnetfirst.Data;
using aspnetfirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using aspnetfirst.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace aspnetfirst.Controllers
{
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly BetContext _context;

        private readonly IHubContext<CrudUserHub> _hubContext;

        public UsersController(BetContext context, IHubContext<CrudUserHub> hubContext, RoleManager<IdentityRole> roleManagers, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            roleManager = roleManagers;
            _hubContext = hubContext;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var context = _context.Match.Include(m => m.UserMatches).ThenInclude(m => m.User).Include(m => m.Team_home).Include(m => m.Team_guest);

            return View(await context.ToListAsync());
        }

        public async Task<IActionResult> WatchUsers() {
            if (User.Identity.IsAuthenticated)
            {
                    //if(HttpContext.Session.GetString("UserName") == "") 
                    //{
                        HttpContext.Session.SetString("UserName", User.Identity.Name);
                        await _hubContext.Clients.All.SendAsync("Notify", $"{User.Identity.Name} is logined at: {DateTime.Now}");
                    //}
                    return View(await _context.User.ToListAsync());
            }
            else
                return RedirectToAction("Login");
         }
        [Authorize(Roles = "user,admin")]
        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var x = HttpContext.Session.GetString("UserName");
            if (x == null)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            }

            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);

            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
        [Authorize(Roles="admin")]
        // GET: Users/Create
        
        public async Task<IActionResult> Create()
        {
            var x = HttpContext.Session.GetString("UserName");
            if (x == null)
            {
                await _signInManager.SignOutAsync();

                return RedirectToAction("Login");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register([Bind("UserName,UserPassword")]User user)
        {
            if (ModelState.IsValid)
            {
                User users = new User { UserPassword = user.UserPassword, UserName = user.UserName};
                

                var result = await _userManager.CreateAsync(user, user.UserPassword);
                if (result.Succeeded)
                {

                    bool userRoleExists = await roleManager.RoleExistsAsync("user");
                    bool adminRoleExists = await roleManager.RoleExistsAsync("admin");
                    if (!userRoleExists)
                        await roleManager.CreateAsync(new IdentityRole("user"));
                    if (!adminRoleExists)
                        await roleManager.CreateAsync(new IdentityRole("admin"));

                    if(user.UserName == "Ali782")
                        await _userManager.AddToRoleAsync(user, "admin");
                    else
                    await _userManager.AddToRoleAsync(user,"user");
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Login", "Users");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(user);
        }

        public IActionResult Login() => View();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName,UserPassword")]User user)
        {
            if (ModelState.IsValid)
            {
                var result =
            await _signInManager.PasswordSignInAsync(user.UserName, user.UserPassword, true, false);
                if (result.Succeeded)
                {
                    TempData["TempStatus"] = "You logined";
                    return RedirectToAction("WatchUsers", "Users");
                }
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {

            await _signInManager.SignOutAsync();
             return RedirectToAction("Login", "Users");
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,UserPassword,Points")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                TempData["TempStatus"] = $"User {user.UserName} added";
                return RedirectToAction(nameof(WatchUsers));
            }
            return View(user);
        }

        [Authorize(Roles = "admin")]
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var x = HttpContext.Session.GetString("UserName");
            if (x == null)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            }
            if (id == null)
            {
                return NotFound();
            }

             //var user = await _context.User.FindAsync(id);
             var user = await _userManager.FindByIdAsync(id);
          
            if (user == null)
            {
                return NotFound();
            }
            
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,[Bind("Id,UserName,UserPassword,Points")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                var users = await _userManager.FindByIdAsync(id);
                users.UserName = user.UserName;
                users.UserPassword = user.UserPassword;
                users.Points = user.Points;
                IdentityResult x = await _userManager.UpdateAsync(users);
                    if(!x.Succeeded)
                    {
                        return View(user);
                    }
             
            }
            
            TempData["TempStatus"] = $"The user{user.UserName} is edited";
            return RedirectToAction(nameof(WatchUsers));
        }
        [Authorize(Roles = "admin")]
        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id,string ReturnUrl="Access Denied")
        {
            var x = HttpContext.Session.GetString("UserName");
            if (x == null)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            }
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {

            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            TempData["TempStatus"] = $"The user{user.UserName} is deleted";
            return RedirectToAction(nameof(WatchUsers));
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
