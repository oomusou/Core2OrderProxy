namespace OrderLibrary
{
    public class OrderService : PriceInterface
    {
        public double GetPrice(double discount, double price)
        {
            return discount * price;
        }
    }
}