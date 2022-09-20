using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Movie.Service.Interface;
using Movie.Domain.Models;
using Movie.Domain.DTO;
using Movie.Domain.Identity;
using Movie.Repository.Implementation;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Movie.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IUserService _userService;

        public MovieController(IMovieService movieService, IUserService userService)
        {
            _movieService = movieService;
            _userService = userService;
        }

        // GET: Tickets
        public IActionResult Index()
        {          
            var allMovies = _movieService.GetAllTickets();
            return View(allMovies);
        }

        // GET: Tickets/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = this._movieService.GetDetailsForTicket(id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Description, datum, zanr, Price, ImageURL")] MovieFilm film)
        {
            if (ModelState.IsValid)
            {
                this._movieService.CreateNewTicket(film);
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }
        public IActionResult AddTicketToCard(Guid? id)
        {
            var model=this._movieService.GetShoppingCartInfo(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTicketToCard([Bind("FilmId", "Kvalitet")]AddToShoppingCartDto item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result=this._movieService.AddToShoppingCart(item, userId);
            MovieUsers user = _userService.Get(userId);
            var accountSID = "ACcb5ff2b20332747e2b91ec16438b1b44";
            var authToken = "6646a00114a64621e56cdd8804f706f2";
            TwilioClient.Init(accountSID, authToken);
            var tonum = user.PhoneNumber;
            var from = "+19786523857";
            if(result)
            {
                var message = MessageResource.Create(
                body: "New film is successfully added to your card. Check it!",
                from: new Twilio.Types.PhoneNumber("+1 978 652 3857"),
                to: new Twilio.Types.PhoneNumber(user.PhoneNumber));
                //var message = MessageResource.Create(to: new Twilio.Types.PhoneNumber(user.PhoneNumber), from: new Twilio.Types.PhoneNumber("+19786523857"), body: "New film is successfully added to your card. Check it!");

                //return Content(message.Sid);
                return RedirectToAction("Index", "Movie");
            }
            return View(item);
        }

        // GET: Tickets/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = this._movieService.GetDetailsForTicket(id);
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Name,Description, datum, zanr, Price, ImageURL")] MovieFilm film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._movieService.UpdeteExistingTicket(film);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(film.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Tickets/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = this._movieService.GetDetailsForTicket(id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._movieService.DeleteTicket(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(Guid id)
        {
            return this._movieService.GetDetailsForTicket(id) != null;
        }
    }
}
