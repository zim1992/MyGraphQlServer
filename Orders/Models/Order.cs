using System;

namespace Orders.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public Guid CustomerId { get; set; }
        public  OrderStatus Status { get; set;  }
        
        public Order(string name, string description, DateTime created, Guid customerId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Created = created;
            CustomerId = customerId;
            Status = OrderStatus.Created; 
        }
        
        [Flags]
        public enum OrderStatus
        {
            Created = 2,
            Processing = 4,
            Completed = 8,
            Cancelled = 16,
            Closed = 32,
        }
    }
}