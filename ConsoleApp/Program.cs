using System;
using MemberLibrary;
using OrderLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> OrderProxy(Predicate<string> isMember) =>
                isMember("Sam") ? 
                (Func<double, double, double>) OrderService.GetPrice : 
                (discount, price) => price;
            
            var realPrice = OrderProxy(MemberService.IsMember)(0.8, 800);
            
            Console.WriteLine("Real price : {0}", realPrice);
        }
    }
}