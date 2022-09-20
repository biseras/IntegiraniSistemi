using Movie.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Domain.Domain
{
    public class ShoppingCart: BaseEntity
    {
        public string OwnerId { get; set; }
        public MovieUsers Owner { get; set; }
        public virtual ICollection<FilminShoppingCart> filmsinshoppingcart { get; set; }//ticketsinshoppingcart
    }
}
