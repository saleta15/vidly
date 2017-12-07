using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Klk"};
//            return View(movie);  
//            return Content("mariconazo");
//            return HttpNotFound();
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "CUstomer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            ViewData["Movie"] = movie;
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }
        //movies
        public ActionResult Index(int? pageIndex, string soryBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrEmpty(soryBy))
                soryBy = "Name";
            return Content(String.Format("{0}, {1}", pageIndex, soryBy));
        }


        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}