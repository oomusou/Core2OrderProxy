using System;
using OrderLibrary;

namespace ConsoleApp
{
    public static class OrderProxy
    {
        public static Func<double, double, double> GetPrice(Predicate<string> isMember)
        {
            return isMember("Sam") ? 
                   (Func<double, double, double>) OrderService.GetPrice : 
                   (discount, price) => price;
        }
    }
}