using System;
using System.Reflection;

namespace Orders.Models
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Customer(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        
        public Customer(Guid id, string name)
        {
            Id = id;
            Name = name; 
        }
        
    }
}