using Movie.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Interface
{
    public interface IUserService
    {
        MovieUsers Get(string id);

    }
}
