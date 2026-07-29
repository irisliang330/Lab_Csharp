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

    //12-7 instance var vs static var
    public class StaticLab
    {
        public int instanceCount;
        public static int staticCount;
    }

    //15-1 Enum
    public enum Role { Admin, UserRD, UserMKT }

    //15-10 struct
    public struct Product
    {
        //public string ProductName;
        //public decimal ProductPrice;

        //15-12 struct constructor
        public Product(string productName, string productPrice)
        {
            ProductName = productName;
            ProductPrice = decimal.Parse(productPrice);
        }

        //16-6 Try Parse
        public Product(string productName, decimal productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        //15-11 var to property in struct
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        

    }
}
