using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Orders.Models;
namespace Orders.Services
{
    public class CustomerService : ICustomerService
    {
        private IList<Customer> _customers;

        public CustomerService()
        {
            _customers = new List<Customer>
            {
                new Customer(new Guid("360506b3-003e-48b2-a5b7-655b401ae1b4"),"John"),
                new Customer(new Guid("b3960d81-48c4-4b6c-a309-d347a65e8b06"),"Merriam"),
                new Customer(new Guid("cac67348-450d-487a-8269-2366ffbe5596"),"Max"),
                new Customer(new Guid("b0e7a074-6090-47e9-884f-48c299de36e4"), "Rakel"),
                new Customer(new Guid("02f4691d-7c37-4ace-9403-4d963ee5dc1a"), "goodness")
            };

        }

        public Customer GetCustomerById(Guid id) => _customers.Single(x => x.Id == id);

        public Task<Customer> GetCustomerByIdAsync(Guid id) => Task.FromResult(_customers.Single(x => x.Id == id));

        public Task<IEnumerable<Customer>> GetCustomersAsync() => Task.FromResult(_customers.AsEnumerable());
        
    }

    public interface ICustomerService
    {
        Customer GetCustomerById(Guid id);
        Task<Customer> GetCustomerByIdAsync(Guid id);
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}