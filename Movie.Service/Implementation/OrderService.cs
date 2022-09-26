using Movie.Domain.Domain;
using Movie.Repository.Interface;
using Movie.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public OrderService(IOrderRepository orderRepository, IUserRepository _userRepository)
        {
            this._orderRepository = orderRepository;
            this._userRepository = _userRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return _orderRepository.GetOrderDetails(model);
        }

        public List<Order> GetAllOrdersByUser(string userId)
        {
            return _orderRepository.GetAllOrdersByUser(userId);
        }

        public Order GetOrderDetailsById(Guid id)
        {
            return _orderRepository.GetOrderDetailsById(id);
        }
    }
}
