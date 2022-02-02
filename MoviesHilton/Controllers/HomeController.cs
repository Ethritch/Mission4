using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesHilton.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHilton.Controllers
{
    public class HomeController : Controller
    {
        

        private MovieFormContext _MfContext { get; set; }

        //Constructor
        public HomeController(MovieFormContext someName)
        {
            
            _MfContext = someName;

        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _MfContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Movies(MovieForm ar)
        {
            if(!ModelState.IsValid)
            {
                _MfContext.Add(ar);
                _MfContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _MfContext.Categories.ToList();

                return View(ar);

            }
        }
        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var form = _MfContext.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();

            return View(form);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = _MfContext.Categories.ToList();

            var form = _MfContext.Movies.Single(x => x.MovieId == movieid);

            return View("Movies", form);
        }

        [HttpPost]
        public IActionResult Edit (MovieForm blah)
        {
            _MfContext.Update(blah);
            _MfContext.SaveChanges();

            return RedirectToAction("MovieList");

        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var form = _MfContext.Movies.Single(x => x.MovieId == movieid);

            return View(form);
        }

        [HttpPost]
        public IActionResult Delete (MovieForm ar)
        {
            _MfContext.Movies.Remove(ar);
            _MfContext.SaveChanges();

            return RedirectToAction("MovieList");
        }


    }
}
 