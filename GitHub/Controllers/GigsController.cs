using GitHub.Models;
using GitHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GitHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var obj = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(obj);
        }
    }
}