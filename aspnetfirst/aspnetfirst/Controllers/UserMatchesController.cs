using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspnetfirst.Data;
using aspnetfirst.Models;

namespace aspnetfirst.Controllers
{
    public class UserMatchesController : Controller
    {
        private readonly BetContext _context;

        public UserMatchesController(BetContext context)
        {
            _context = context;
        }

        // GET: UserMatches
        public async Task<IActionResult> Index()
        {
            var betContext = _context.UserMatch.Include(u => u.Match)
                .ThenInclude(u=>u.Team_home)
                .Include(u=>u.Match)
                .ThenInclude(u=>u.Team_guest)
                .Include(u => u.User);
            return View(await betContext.ToListAsync());
        }

        // GET: UserMatches/Details/5
        public async Task<IActionResult> Details(int? match_id,int? user_id)
        {
            if (user_id == null || match_id == null)
            {
                return NotFound();
            }

            var userMatch = await _context.UserMatch
                .Include(u => u.Match)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.MatchId == match_id && Convert.ToInt32(m.UserId) == user_id);
            if (userMatch == null)
            {
                return NotFound();
            }

            return View(userMatch);
        }

        // GET: UserMatches/Create
        public IActionResult Create()
        {
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: UserMatches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserMatchId,MatchId,UserId")] UserMatch userMatch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userMatch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId", userMatch.MatchId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userMatch.UserId);
            return View(userMatch);
        }

        // GET: UserMatches/Edit/5
        public async Task<IActionResult> Edit(int? user_id,int? match_id)
        {
            if (user_id == null || match_id == null)
            {
                return NotFound();
            }

            var userMatch = await _context.UserMatch.FindAsync(match_id,user_id);
            if (userMatch == null)
            {
                return NotFound();
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId", userMatch.MatchId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userMatch.UserId);
            return View(userMatch);
        }

        // POST: UserMatches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( [Bind("UserMatchId,MatchId,UserId")] UserMatch userMatch)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userMatch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserMatchExists(userMatch.MatchId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId", userMatch.MatchId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userMatch.UserId);
            return View(userMatch);
        }

        // GET: UserMatches/Delete/5
        public async Task<IActionResult> Delete(int? match_id,int? user_id)
        {

            var userMatch = await _context.UserMatch
                .Include(u => u.Match)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.MatchId == match_id && Convert.ToInt32(m.UserId) == user_id);
            if (userMatch == null)
            {
                return NotFound();
            }

            return View(userMatch);
        }

        // POST: UserMatches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int ?id,[Bind("UserMatchId,MatchId,UserId")] UserMatch userMatch)
        {
            var matchUser = _context.UserMatch.Find(userMatch.MatchId,userMatch.UserId);
            _context.UserMatch.Remove(matchUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserMatchExists(int id)
        {
            return _context.UserMatch.Any(e => e.MatchId == id);
        }
    }
}
