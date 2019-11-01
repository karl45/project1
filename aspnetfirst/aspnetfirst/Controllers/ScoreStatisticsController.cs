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
    public class ScoreStatisticsController : Controller
    {
        private readonly BetContext _context;

        public ScoreStatisticsController(BetContext context)
        {
            _context = context;
        }

        // GET: ScoreStatistics
        public async Task<IActionResult> Index()
        {
            var betContext = _context.ScoreStatistic.Include(s => s.Match);
            return View(await betContext.ToListAsync());
        }

        // GET: ScoreStatistics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreStatistic = await _context.ScoreStatistic
                .Include(s => s.Match)
                .FirstOrDefaultAsync(m => m.ScoreStatisticId == id);
            if (scoreStatistic == null)
            {
                return NotFound();
            }

            return View(scoreStatistic);
        }

        // GET: ScoreStatistics/Create
        public IActionResult Create()
        {
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId");
            return View();
        }

        // POST: ScoreStatistics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScoreStatisticId,Score,Numberofpenalty,NumberofyellowCard,Numberofredcard,MatchId")] ScoreStatistic scoreStatistic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scoreStatistic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId", scoreStatistic.MatchId);
            return View(scoreStatistic);
        }

        // GET: ScoreStatistics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreStatistic = await _context.ScoreStatistic.FindAsync(id);
            if (scoreStatistic == null)
            {
                return NotFound();
            }
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId", scoreStatistic.MatchId);
            return View(scoreStatistic);
        }

        // POST: ScoreStatistics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScoreStatisticId,Score,Numberofpenalty,NumberofyellowCard,Numberofredcard,MatchId")] ScoreStatistic scoreStatistic)
        {
            if (id != scoreStatistic.ScoreStatisticId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scoreStatistic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreStatisticExists(scoreStatistic.ScoreStatisticId))
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
            ViewData["MatchId"] = new SelectList(_context.Match, "MatchId", "MatchId", scoreStatistic.MatchId);
            return View(scoreStatistic);
        }

        // GET: ScoreStatistics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreStatistic = await _context.ScoreStatistic
                .Include(s => s.Match)
                .FirstOrDefaultAsync(m => m.ScoreStatisticId == id);
            if (scoreStatistic == null)
            {
                return NotFound();
            }

            return View(scoreStatistic);
        }

        // POST: ScoreStatistics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scoreStatistic = await _context.ScoreStatistic.FindAsync(id);
            _context.ScoreStatistic.Remove(scoreStatistic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoreStatisticExists(int id)
        {
            return _context.ScoreStatistic.Any(e => e.ScoreStatisticId == id);
        }
    }
}
