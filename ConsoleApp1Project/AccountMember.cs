using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Project
{
    class AccountMember
    {
        public string MemberID { get; set; }
        public string MemberPassword { get; set; }
        public string Fullname { get; set; }
        public int MemberRole { get; set; }

        public AccountMember(string memberId, string memberPassword, string fullname, int memberRole)
        {
            MemberID = memberId;
            MemberPassword = memberPassword;
            Fullname = fullname;
            MemberRole = memberRole;
        }
    }

}
