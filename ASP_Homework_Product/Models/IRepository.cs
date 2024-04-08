using System.Collections.Generic;

namespace Advertisement.Models
{
    public interface IRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
    }
}
