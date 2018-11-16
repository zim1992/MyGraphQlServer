using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orders.Models;
namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders = new List<Order>();

        public OrderService()
        {
            _orders.Add(
                new Order(name: "pen", description: "used for writing information", created: DateTime.Today.AddDays(4),
                    customerId: new Guid("360506b3-003e-48b2-a5b7-655b401ae1b4"))
            );
            _orders.Add(
                new Order(name: "paper", description: "chopped from a tree", created: DateTime.Today.AddDays(7),
                    customerId: new Guid("360506b3-003e-48b2-a5b7-655b401ae1b4"))
            );
            _orders.Add(
                new Order(name: "chair", description: "used for sitting on", created: DateTime.Today.AddDays(32),
                    customerId: new Guid("b3960d81-48c4-4b6c-a309-d347a65e8b06"))
            );
            _orders.Add(
                new Order(name: "Table", description: "used for working", created: DateTime.Today.AddDays(4),
                    customerId: new Guid("360506b3-003e-48b2-a5b7-655b401ae1b4"))
            );
            _orders.Add(
                new Order(name: "Computer", description: "used for writing information",
                    created: DateTime.Today.AddDays(9),
                    customerId: new Guid("360506b3-003e-48b2-a5b7-655b401ae1b4"))
            );
            _orders.Add(
                new Order(name: "keyboard", description: "used for importing information into a computer",
                    created: DateTime.Today.AddDays(34),
                    customerId: new Guid("360506b3-003e-48b2-a5b7-655b401ae1b4"))
            );
            _orders.Add(
                new Order(name: "pen", description: "used for writing information", created: DateTime.Today.AddDays(8),
                    customerId: new Guid("b3960d81-48c4-4b6c-a309-d347a65e8b06"))
            );
            _orders.Add(
                new Order(name: "pen", description: "used for writing information", created: DateTime.Today.AddDays(3),
                    customerId: new Guid("cac67348-450d-487a-8269-2366ffbe5596"))
            );
        }

        public Task<Order> GetByOrderIdAsync(Guid id) => Task.FromResult(_orders.Single(x => x.Id == id));

        public Task<IEnumerable<Order>> GetOrdersAsync() => Task.FromResult(_orders.AsEnumerable());

    }

    public interface IOrderService
    {
        Task<Order> GetByOrderIdAsync(Guid id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
    
}