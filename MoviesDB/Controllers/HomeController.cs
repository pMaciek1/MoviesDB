using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesDB.Data;
using MoviesDB.Models;

namespace MoviesDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public int MoviesCount()
        {
            var count = _context.Movies.Count(t => t.Id == '1');
            return count;
        }
        public int MoviesToWatchCount()
        {
            var count = _context.MoviesToWatch.Count(t => t.Id == '1');
            return count;
        }
    }
}
