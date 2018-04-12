using MemberLibrary;
using OrderLibrary;

namespace ConsoleApp
{
    public class OrderProxy : PriceInterface
    {
        private readonly PriceInterface _orderService = new OrderService();
        private readonly MemberService _memberService = new MemberService();
        
        public double GetPrice(double discount, double price)
        {
            return _memberService.IsMember("Sam") ? 
                   _orderService.GetPrice(discount, price) : 
                   price;

        }
    }
}