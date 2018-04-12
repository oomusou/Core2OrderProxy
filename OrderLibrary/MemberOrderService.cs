using MemberLibrary;

namespace OrderLibrary
{
    public class MemberOrderService : OrderService
    {
        private readonly MemberService _memberService = new MemberService();

        public override double GetPrice(double discount, double price)
        {
            return _memberService.IsMember("Sam") ?
                   base.GetPrice(discount, price) :
                   price;
        }
    }
}