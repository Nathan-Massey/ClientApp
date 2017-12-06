using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Interface
{
    interface IOrderDataService
    {
        // Single order
        Order GetSingleOrder(int id);

        // All the orders
        List<Order> GetAllOrders();

        // All orders of a single client
        List<Order> GetAllOrdersByClient(int clientId);

        // All orders of a client per target date
        List<Order> GetAllOrderByClientAndRange(int clietId, DateTime range);

        // Create
        bool Create(Order newOrder);

        // Update
        bool UpdateOrder(Order updatedOrder);

        // Delete
        bool DeleteOrder(int id);
    }
}
