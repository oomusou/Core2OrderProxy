using System;
using OrderLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceInterface memberOrderService = new MemberOrderService();
            var realPrice = memberOrderService.GetPrice(0.8, 800);
            
            Console.WriteLine("Real price : {0}", realPrice);
        }
    }
}