using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VHSOnly.Models;
using VHSOnly.ViewModels;

namespace VHSOnly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Honey I Shrunk The Kids" };
            var customers = new List<Customer>
            {
                new Customer{Name= "Customer 1"},
                new Customer{Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //ViewData and ViewBag both rely on 'magic' and are fragile because the don't update if you change the code in one place but not the other.
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content($"id={id}");
        }
        [Route("Movies")]
        public ActionResult Index()
        {
            var movies = new List<Movie>
           {
               new Movie{Name = "Honey I Shrunk The Kids"},
               new Movie{Name = "Baby Boy"},
               new Movie{Name = "Ace Ventura"},
           };

            var movieViewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(movieViewModel);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
