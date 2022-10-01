using Movie.Domain.DTO;
using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Interface
{
    public interface IMovieService
    {
        List<MovieFilm> GetAllTickets();
        MovieFilm GetDetailsForTicket(Guid? id);
        MovieFilm GetMovieByName(string name);
        void CreateNewTicket(MovieFilm t);
        void UpdeteExistingTicket(MovieFilm t);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        void DeleteTicket(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
