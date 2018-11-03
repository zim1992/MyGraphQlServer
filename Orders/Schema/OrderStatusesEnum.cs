using GraphQL.Types;
using Orders.Models;

namespace Orders.Schema
{
    public class OrderStatusesEnum : EnumerationGraphType
    {
        public OrderStatusesEnum()
        {
            Name = "OrderStatuses";
            AddValue("Created", "order was created", Order.OrderStatus.Created);
            AddValue("Processing", "order is in process", Order.OrderStatus.Processing);
            AddValue("Completed", "order is completed", Order.OrderStatus.Completed);
            AddValue("Cancelled", "order was cancelled", Order.OrderStatus.Cancelled);
            AddValue("Closed", "order was Closed", Order.OrderStatus.Closed);
        }
    }
}