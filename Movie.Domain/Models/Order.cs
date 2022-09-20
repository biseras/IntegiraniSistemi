using Movie.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Domain.Domain
{
    public class Order:BaseEntity
    {
        public string UserId { get; set; }
        public MovieUsers User { get; set; }

        public virtual ICollection<FilmInOrder> FilmInOrders { get; set; }//TicketinOrder
    }
}
