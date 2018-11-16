using System.Security.Cryptography.X509Certificates;
using GraphQL.Types;
using Orders.Models;

namespace Orders.Schema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Name = "Customer";
            Description = "These are the customers in the system"; 
            Field(c => c.Id).Description("Customer Id");
            Field(c => c.Name).Description("Customer Name");

        }
        
    }
}