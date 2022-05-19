using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movies_MVC_6.Data;
using Movies_MVC_6.Models;

namespace Movies_MVC_6.Controllers
{
    public class MovieAwardController : Controller
    {
        private readonly MovieContext _context;

        public MovieAwardController(MovieContext context)
        {
            _context = context;
        }

        // GET: MovieAward
        public async Task<IActionResult> Index()
        {
            var movieContext = _context.MovieAward.Include(m => m.Award).Include(m => m.Movie);
            return View(await movieContext.ToListAsync());
        }

        // GET: MovieAward/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieAward = await _context.MovieAward
                .Include(m => m.Award)
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.MovieAwardID == id);
            if (movieAward == null)
            {
                return NotFound();
            }

            return View(movieAward);
        }

        // GET: MovieAward/Create
        public IActionResult Create()
        {
            ViewData["AwardID"] = new SelectList(_context.Awards, "AwardID", "AwardID");
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID");
            return View();
        }

        // POST: MovieAward/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieAwardID,MovieID,AwardID")] MovieAward movieAward)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieAward);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AwardID"] = new SelectList(_context.Awards, "AwardID", "AwardID", movieAward.AwardID);
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", movieAward.MovieID);
            return View(movieAward);
        }

        // GET: MovieAward/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieAward = await _context.MovieAward.FindAsync(id);
            if (movieAward == null)
            {
                return NotFound();
            }
            ViewData["AwardID"] = new SelectList(_context.Awards, "AwardID", "AwardID", movieAward.AwardID);
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", movieAward.MovieID);
            return View(movieAward);
        }

        // POST: MovieAward/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieAwardID,MovieID,AwardID")] MovieAward movieAward)
        {
            if (id != movieAward.MovieAwardID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieAward);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieAwardExists(movieAward.MovieAwardID))
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
            ViewData["AwardID"] = new SelectList(_context.Awards, "AwardID", "AwardID", movieAward.AwardID);
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", movieAward.MovieID);
            return View(movieAward);
        }

        // GET: MovieAward/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieAward = await _context.MovieAward
                .Include(m => m.Award)
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.MovieAwardID == id);
            if (movieAward == null)
            {
                return NotFound();
            }

            return View(movieAward);
        }

        // POST: MovieAward/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieAward = await _context.MovieAward.FindAsync(id);
            _context.MovieAward.Remove(movieAward);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieAwardExists(int id)
        {
            return _context.MovieAward.Any(e => e.MovieAwardID == id);
        }
    }
}
