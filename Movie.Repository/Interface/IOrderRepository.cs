using Movie.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderDetails(BaseEntity model);
    }
}
