using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Domain.DTO
{
    public class AddToShoppingCartDto
    {
        public MovieFilm SelectedFilm { get; set; }
        public Guid FilmId { get; set; }
        public int Kvalitet { get; set; }
    }
}
