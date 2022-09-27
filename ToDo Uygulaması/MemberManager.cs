using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public static class MemberManager
    {
        public static List<Member> Members;

        static MemberManager()
        {
            Members = DefaultMembers();
        }

        public static List<Member> DefaultMembers()
        {
            return new List<Member>(){
            new Member(1,"İrfan Mert"),
            new Member(2,"Batuhan Gül"),
            new Member(3,"Fatma Çelik"),
            new Member(4,"Zeynep Özkan"),
            new Member(5,"Aslı Maden"),
            };
        }
    }
}