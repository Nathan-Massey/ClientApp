using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService.Interface;

namespace DataService.Mock
{
    class OrderMockDataService : IOrderDataService
    {
        // Field
        private List<Order> _mock;

        // Constructor
        public OrderMockDataService()
        {
            _mock = new List<Order>()
            {
                 new Order() {Id = 1, Shipped = true, total = 100, Description = "Keyboard."},
                 new Order() {Id = 2, Shipped = false, total = 200, Description = "Monitor."},
                 new Order() {Id = 3, Shipped = true, total = 300, Description = "Gaming Console."},
                 new Order() {Id = 4, Shipped = false, total = 400, Description = "TV."},
                 new Order() {Id = 5, Shipped = true, total = 500, Description = "Laptop."},
            };
        }
        public bool CreateOrder(Order newOrder)
        {
            _mock.Add(newOrder);

            return true;
        }

        public bool DeleteOrder(int id)
        {
            var orderToBeDeleted = GetSingleOrder(id);

            _mock.Remove(orderToBeDeleted);

            return true;
        }

        public List<Order> GetAllOrders()
        {
            return _mock;
        }

        public Order GetSingleOrder(int id)
        {
            return _mock.Single(order => order.Id == id);
        }

        public bool UpdateOrder(Order updatedOrder)
        {
            var oldOrder = GetSingleOrder(updatedOrder.Id);

            _mock.Remove(oldOrder);
            _mock.Add(updatedOrder);

            return true;
        }
    }
}
