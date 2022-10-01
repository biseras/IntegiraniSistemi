using Movie.Domain.Domain;
using Movie.Domain.DTO;
using Movie.Domain.Models;
using Movie.Repository.Interface;
using Movie.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Service.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IRepository<FilminShoppingCart> _filminShoppingCartRepository;
        private readonly IUserRepository _userRepository;
        public MovieService(IMovieRepository movieRepository, IRepository<FilminShoppingCart> filminShoppingCartRepository, IUserRepository userRepository)
        {
            _movieRepository = movieRepository;
            _filminShoppingCartRepository = filminShoppingCartRepository;
            _userRepository = userRepository;
        }
        public bool AddToShoppingCart(AddToShoppingCartDto item, string userID)
        {
            //var userShoppingCard = await _context.ShoppingCarts.Where(z => z.OwnerId.Equals(userId)).FirstOrDefaultAsync();
            var user = this._userRepository.Get(userID);
            var userShoppingCard = user.UserCart;

            if (item.FilmId != null && userShoppingCard != null)
            {
                var film = this.GetDetailsForTicket(item.FilmId);
                if (film != null)
                {
                    FilminShoppingCart itemToAdd = new FilminShoppingCart
                    {
                        Id=Guid.NewGuid(),
                        film = film,
                        FilmId = film.Id,
                        shoppingcart = userShoppingCard,
                        ShoppingCartId = userShoppingCard.Id,
                        Kvalitet = item.Kvalitet
                    };
                    this._filminShoppingCartRepository.Insert(itemToAdd);
                    return true;
                }
                return false;
            }
            return false;
        }

        public void CreateNewTicket(MovieFilm t)
        {
            this._movieRepository.Insert(t);
        }

        public void DeleteTicket(Guid id)
        {
            var ticket = this.GetDetailsForTicket(id);
            this._movieRepository.Delete(ticket);
        }

        public List<MovieFilm> GetAllTickets()
        {
            return this._movieRepository.GetAll().ToList();
        }

        public MovieFilm GetDetailsForTicket(Guid? id)
        {
            return this._movieRepository.Get(id);
        }

        public MovieFilm GetMovieByName(string name)
        {
            return this._movieRepository.GetByName(name);
        }

        public AddToShoppingCartDto GetShoppingCartInfo(Guid? id)
        {
            var film = this.GetDetailsForTicket(id);
            AddToShoppingCartDto model = new AddToShoppingCartDto
            {
                SelectedFilm = film,
                FilmId = film.Id,
                Kvalitet = 1
            };
            return model;
        }

        public void UpdeteExistingTicket(MovieFilm t)
        {
            this._movieRepository.Update(t);
        }
    }
}
