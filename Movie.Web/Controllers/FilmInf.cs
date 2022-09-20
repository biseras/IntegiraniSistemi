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

namespace Movie.Web.Controllers
{
    public class FilmInf : Controller
    {
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
            return View("Index", data);
        }

    }
}
