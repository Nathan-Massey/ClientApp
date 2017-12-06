using DataService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services
{
    class OrderDataService : IOrderDataService
    {
        // Field
        private DatabaseToClassesDataContext _db;

        // Constructor
        public OrderDataService()
        {
            _db = new DatabaseToClassesDataContext();
        }

        // Methods
        public List<Order> GetAllOrderByClientAndRange(int clietId, DateTime range)
        {
            var orders = _db.Orders
                        .Where(row => row.Client_Id == clietId)
                        .Where(row => row.Created <= range);

            return orders.ToList();
        }

        public List<Order> GetAllOrders()
        {
            var allOrders = _db.Orders;

            return allOrders.ToList();
        }

        public List<Order> GetAllOrdersByClient(int clientId)
        {
            var ordersByClient = _db.Orders
                                 .Where(row => row.Client_Id == clientId);

            return ordersByClient.ToList();
        }

        public Order GetSingleOrder(int id)
        {
            var order = _db.Orders
                       .Where(row => row.Id == id)
                       .Single();

            return order;
        }
    }
}
