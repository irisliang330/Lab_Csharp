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
    public partial class Frm_M15_struct : Form
    {
        public Frm_M15_struct()
        {
            InitializeComponent();
        }

        //15-14 Overload
        public Frm_M15_struct(string Name) 
        { 
            InitializeComponent();
            this.Text = Name;
        }

        //15-10 struct

        string productResult = "資料\n";

        //input
        private void btnUserCommit_Click(object sender, EventArgs e)
        {
            //Product product;

            //15-11 var to property in struct
            //Product product = new Product();

            //15-12 struct constructor
            Product product = new Product(txtProductName.Text, txtProductPrice.Text);

            product.ProductName = txtProductName.Text;
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);

            productResult += $"\n名稱:{product.ProductName}\n價格:{product.ProductPrice}\n";


            //16-6 Try Parse
            decimal price = 0;
            bool isNum = decimal.TryParse(txtProductName.Text, out price);

            if (isNum ==true)
            {
                Product pro01 = new Product(txtProductName.Text, price)
            }
            else
            {
                MessageBox.Show("價格請輸入數字");
                txtProductPrice.Clear();
                txtProductPrice.Focus();
            }

        }

        //output
        private void btnShow_Click(object sender, EventArgs e)
        {
            labShowProduct.Text += productResult;
        }
    }
}
