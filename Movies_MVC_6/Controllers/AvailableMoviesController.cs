using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movies_MVC_6.Data;
using Movies_MVC_6.Models;
using Movies_MVC_6.Models.MovieViewModels;

namespace Movies_MVC_6.Controllers
{
    public class AvailableMoviesController : Controller
    {

        private readonly MovieContext _context;

        public AvailableMoviesController (MovieContext context)
        {
            _context = context;
        }

        // GET: Movie
        public async Task<IActionResult> Index()
        {
            var viewModel = new MovieIndexData();
            viewModel.Movies = await _context.Movies
                .Include(m => m.MovieAward)
                .ThenInclude(m => m.Award)
                .AsNoTracking()
                .OrderBy(m => m.MovieID)
                .ToListAsync();
            return View(viewModel);
        }
        public async Task<IActionResult> Movie(int? id)
        {
            var viewModel = new MovieIndexData();
            viewModel.Movies = await _context.Movies
                .Include(m => m.MovieAward)
                .ThenInclude(m => m.Award)
                .Where(m => m.MovieID == id)
                .ToListAsync();           
            return View(viewModel);
            //.FirstOrDefaultAsync(m => m.MovieID == id)           
        }

    }
}

