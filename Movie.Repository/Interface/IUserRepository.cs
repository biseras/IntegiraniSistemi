using Movie.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<MovieUsers> GetAll();
        MovieUsers Get(string id);
        void Insert(MovieUsers entity);
        void Update(MovieUsers entity);
        void Delete(MovieUsers entity);
    }
}
