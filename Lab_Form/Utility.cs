using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Form
{
    public class MemberData
    {
        public string Name;
        public string PhoneNumber;
        public DateTime BirthDate;
    }

    // instance var vs static var
    public class StaticLab
    {
        public int instanceCount;
        public static int staticCount;
    }

    // Enum
    public enum Role { Admin, UserRD, UserMKT }
}
