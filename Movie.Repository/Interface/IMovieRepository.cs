using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository.Interface
{
    public interface IMovieRepository
    {
        IEnumerable<MovieFilm> GetAll();
        MovieFilm Get(Guid? id);
        void Insert(MovieFilm entity);
        void Update(MovieFilm entity);
        void Delete(MovieFilm entity);
        MovieFilm GetByName(string name);
    }
}
