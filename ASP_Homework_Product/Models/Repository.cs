using System.Collections.Generic;
using System.Linq;

namespace Advertisement.Models
{
    public class Repository: IRepository
    {
        private readonly List<Order> _orders = new List<Order>();

        public IEnumerable<Order> GetAllOrders() => _orders;

        public Order GetOrderById(int id) => _orders.FirstOrDefault(o => o.Id == id);

        public void AddOrder(Order order)
        {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            var index = _orders.FindIndex(o => o.Id == order.Id);
            if (index != -1)
            {
                _orders[index] = order;
            }
            else
            {
                AddOrder(order);
            }
        }
    }
}
