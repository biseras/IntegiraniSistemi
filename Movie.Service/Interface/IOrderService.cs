using Movie.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        List<Order> GetAllOrdersByUser(string userId);
        Order GetOrderDetails(BaseEntity model);

        Order GetOrderDetailsById(Guid id);
    }
}
