using System;

namespace MemberLibrary
{
    public static class MemberService
    {
        public static bool IsMember(string account)
        {
            return account == "Sam";
        }
    }
}