using  GraphQL.Types;
using Orders.Models;
using Orders.Services;

namespace Orders.Schema
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerService customers)
        {
            Name = "Order";
            Description = "This is an order from the customer";
            
            Field(o => o.Id).Description("Order Number");
            Field(o => o.Name).Description("Name of the item");
            Field(o => o.Description).Description("");
            Field<CustomerType>("customer", resolve: content => customers.GetCustomerByIdAsync(content.Source.CustomerId));
            Field(o => o.Created);
        }
    }
}