using System;
using OrderLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceInterface orderProxy = new OrderProxy();
            var realPrice = orderProxy.GetPrice(0.8, 800);
            
            Console.WriteLine("Real price : {0}", realPrice);
        }
    }
}