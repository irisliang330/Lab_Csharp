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
            mc02.Methdo03Internal();
            mc02.Methdo04Public();
            mc02.Methdo05CallMethod01And02();
        }
    }
}
