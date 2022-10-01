using Microsoft.EntityFrameworkCore;
using Movie.Domain.Models;
using Movie.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Repository.Implementation
{
    public class MovieRepository : IMovieRepository
    {

        private readonly ApplicationDbContext context;
        private DbSet<MovieFilm> entities;
        string errorMessage = string.Empty;

        public MovieRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<MovieFilm>();
        }

        public void Delete(MovieFilm entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public MovieFilm Get(Guid? id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<MovieFilm> GetAll()
        {
            return entities.AsEnumerable();
        }

        public MovieFilm GetByName(string name)
        {
            return entities.SingleOrDefault(s => s.Name == name);
        }

        public void Insert(MovieFilm entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(MovieFilm entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
