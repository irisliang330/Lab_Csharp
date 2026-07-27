using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_HelloForm hello = new Frm_HelloForm();
            hello.Show();

        }

        private void btnMethod_Click(object sender, EventArgs e)
        {

            MyMethod();

        }

        //無回傳值的Method
        void MyMethod()
        {
            string name = "有颱風";
            MessageBox.Show($"我是{name}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.MyNewMethod();
        }


        //有回傳值的Method
        private void button2_Click(object sender, EventArgs e)
        {
            string birthYearResult = GetBirthYear(46);
            MessageBox.Show(birthYearResult);
        }

        string GetBirthYear(int Age)
        {
            int birthYear = DateTime.Now.Year - Age;
            return $"出生年是{birthYear}年";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            MyClass mc02 = new MyClass();
            mc02.Methdod03Internal();
            mc02.Method04Public();
            mc02.Method05CallMethod01And02();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyClass mcPartial = new MyClass();
            mcPartial.Method06PartialClass();
            mcPartial.Methdod03Internal();
            mcPartial.Method04Public();
            mcPartial.Method05CallMethod01And02();
        }

        public void NewMember_Click(object sender, EventArgs e)
        {
            //initialize-1
            MemberData memberData01 = new MemberData(); //create instance
            memberData01.Name = "John";
            memberData01.PhoneNumber = "1234567890";
            memberData01.BirthDate = new DateTime(1990, 8, 20);

            //initialize-2
            MemberData memberData02 = new MemberData()
            {
                Name = "Alice",
                PhoneNumber = "1234567890",
                BirthDate = new DateTime(1980, 1, 1)
            };

            //output
            MessageBox.Show(
                $"會員01姓名:{memberData01.Name}\n" +
                $"會員01電話:{memberData01.PhoneNumber}\n" +
                $"會員01生日:{memberData01.BirthDate}" +
                "\n" +
                $"會員02姓名:{memberData02.Name}\n" +
                $"會員02電話:{memberData02.PhoneNumber}\n" +
                $"會員02生日:{memberData02.BirthDate}");

            MessageBox.Show(
                string.Format(
                "會員姓名:{0}\n會員電話:{1}\n會員生日:{2}",
                memberData01.Name,
                memberData01.PhoneNumber,
                memberData01.BirthDate));
        }

        // Binding Event and Method
        private void btnDataBinding_Click(object sender, EventArgs e)
        {
            //from Designer.cs
            //this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            btnRegitster01.Click += new EventHandler(btnRegisterEvent01_Click);
            btnRegisterEvent02.Click += btnRegisterEvent02_Click;
            btnRegisterEvent02.Click += btnRegisterEvent01_Click;

            //cant bind with click event if dont match delegate
            //btnRegisterEvent02.Click += MyString; 
        }

        //string MyString()
        //{
        //    return "";
        //}

        private void btnRegisterEvent02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registor Event 事件繫結02");
        }



        private void btnRegisterEvent01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registor Event 事件繫結01");
        }

        //Using Delegate

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            Payment pay;
            if (DateTime.Now.Minute %2 == 0)
            {
                pay = PriceA;    
            }
            else
            {
                pay = PriceB;
            }

            decimal amount = decimal.Parse(txtPrice.Text);
            decimal result = pay(amount);
            MessageBox.Show($"{result}");
        }

        //declare delegate
        delegate decimal Payment(decimal amount);

        decimal PriceA(decimal originPrice)
        {
            decimal priceA = originPrice * Convert.ToDecimal(0.8);
            return priceA;
        }
        decimal PriceB(decimal originPrice)
        {
            decimal priceB = originPrice * Convert.ToDecimal(0.6);
            return priceB;
        }
    }
}
