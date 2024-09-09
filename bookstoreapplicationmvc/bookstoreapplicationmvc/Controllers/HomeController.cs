using BookStore.Entity;
using BookStore.Service;
using bookstoreapplicationmvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bookstoreapplicationmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookStore _bookStore;

        public HomeController(ILogger<HomeController> logger, IBookStore bookStore)
        {
            _logger = logger;
            _bookStore = bookStore; 
        }

        public IActionResult Index()
        {
            var Books = _bookStore.GetListOfBooks();
            return View(Books);
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
