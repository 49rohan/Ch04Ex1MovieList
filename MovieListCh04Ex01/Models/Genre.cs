using Microsoft.AspNetCore.Mvc;
using MovieListCh04Ex01.Models;
using System.Diagnostics;

namespace MovieListCh04Ex01.Controllers
{
    public class Genre : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}