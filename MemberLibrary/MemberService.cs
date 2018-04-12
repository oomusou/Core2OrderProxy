using System;

namespace MemberLibrary
{
    public class MemberService
    {
        public bool IsMember(string account)
        {
            return account == "Sam";
        }
    }
}