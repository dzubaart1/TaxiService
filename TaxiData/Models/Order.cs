namespace TaxiData.Models
{
    public class Order
    {
        public Order(Driver driver, string client)
        {
            Driver = driver;
            Client = new Client(client);
            OrderStatus = OrderStatusEnum.Accepted;
        }
        public OrderStatusEnum OrderStatus { get; private set; }
        public Driver Driver { get; private set; }
        public Client Client { get; private set; }

        public void SetStatus(OrderStatusEnum orderStatus)
        {
            OrderStatus = orderStatus;
        }
    }
}
