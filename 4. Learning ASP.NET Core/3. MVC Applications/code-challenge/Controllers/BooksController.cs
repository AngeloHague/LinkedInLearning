using Microsoft.AspNetCore.Mvc;
using code_challenge.Models;

namespace mvc_app.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            var booksController = new BooksModel();
            return View(booksController);
        }
        // GET: BooksController
        public ActionResult Favourite()
        {
            var booksController = new BooksModel();
            return View(booksController);
        }

    }
}
