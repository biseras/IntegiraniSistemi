using Microsoft.AspNetCore.Identity;
using Movie.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Domain.Identity
{
    public class MovieUsers: IdentityUser
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public virtual ShoppingCart UserCart { get; set; }
    }
}
