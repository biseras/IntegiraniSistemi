using Microsoft.AspNetCore.Mvc;
using Movie.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using Movie.Domain.Models;
using Movie.Service.Interface;
using Microsoft.Extensions.Logging;

namespace Movie.Web.Controllers
{
    public class FilmInf : Controller
    {

        private readonly IMovieService _movieService;
        private readonly ILogger<FilmInf> _logger;

        public FilmInf(ILogger<FilmInf> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Movie()
        {
            return View();
        }

        // POST: Ucenicis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Movie([Bind("Name")] MovieDto item )
        {
            if (ModelState.IsValid)
            {
                String name = item.Name;
                
            }
            String namee = item.Name;
            HttpClient client = new HttpClient();
            string URL = "http://www.omdbapi.com/?t="+item.Name+"&apikey=293abe22";
            HttpResponseMessage response = client.GetAsync(URL).Result;
            var data = response.Content.ReadAsAsync<MovieA>().Result;
            data.Added = this._movieService.GetMovieByName(data.Title) != null ? true: false;
            _logger.LogInformation("Korisnikot prebaruva informacii za nekoj film");
            return View("Index", data);
        }

        [HttpGet]
        public ActionResult MovieDetails(string name, bool added)
        {
            HttpClient client = new HttpClient();
            string URL = "http://www.omdbapi.com/?t=" + name + "&apikey=293abe22";
            HttpResponseMessage response = client.GetAsync(URL).Result;
            var data = response.Content.ReadAsAsync<MovieA>().Result;
            data.Added = added;
            _logger.LogInformation("Korisnikot gleda informacii za nekoj film");
            return View("Index", data);
        }

    }
}
