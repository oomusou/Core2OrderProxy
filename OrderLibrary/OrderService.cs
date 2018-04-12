namespace OrderLibrary
{
    public static class OrderService
    {
        public static double GetPrice(double discount, double price)
        {
            return discount * price;
        }
    }
}