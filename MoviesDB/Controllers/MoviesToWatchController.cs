using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesDB.Data;

namespace MoviesDB.Controllers
{
    public class MoviesToWatchController : Controller
    {
        private readonly Context _context;
        public MoviesToWatchController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoviesToWatch.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie==null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseYear,Description")] MovieToWatch movie)
        {
            if(ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _context.MoviesToWatch.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseYear,Description")] MovieToWatch movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _context.MoviesToWatch.FindAsync(id);
            if(movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.MoviesToWatch.FindAsync(id);
            if (movie != null)
            {
                _context.MoviesToWatch.Remove(movie);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
