namespace NorthWindMVC.Models
{
    public class RepositoryOrders
    {
        private NorthwindContext __Context;
        public RepositoryOrders(NorthwindContext context)
        {
            __Context = context;    
        }
        public Order FindOrderById(int id)
        {
            var order = __Context.Orders.Find(id);
            return order;
        }
    }
}
