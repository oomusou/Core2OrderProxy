namespace OrderLibrary
{
    public class OrderService : PriceInterface
    {
        public virtual double GetPrice(double discount, double price)
        {
            return discount * price;
        }
    }
}