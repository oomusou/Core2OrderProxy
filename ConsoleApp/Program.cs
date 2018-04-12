using System;
using MemberLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var realPrice = OrderProxy.GetPrice(MemberService.IsMember)(0.8, 800);
            
            Console.WriteLine("Real price : {0}", realPrice);
        }
    }
}