using Microsoft.EntityFrameworkCore;
using Movie.Domain.Identity;
using Movie.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<MovieUsers> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<MovieUsers>();
        }
        public IEnumerable<MovieUsers> GetAll()
        {
            return entities.AsEnumerable();
        }

        public MovieUsers Get(string id)
        {
            return entities
                .Include(z => z.UserCart)
                .Include(z => z.UserCart.filmsinshoppingcart)
                .Include("UserCart.filmsinshoppingcart.film")
                .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(MovieUsers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(MovieUsers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(MovieUsers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
