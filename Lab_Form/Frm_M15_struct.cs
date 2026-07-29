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

        //15-10 struct

        string productResult = "資料\n";

        //input
        private void btnUserCommit_Click(object sender, EventArgs e)
        {
            //Product product;

            //15-11 var to property in struct
            Product product = new Product();

            product.ProductName = txtProductName.Text;
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);

            productResult += $"\n名稱:{product.ProductName}\n價格:{product.ProductPrice}\n";
        }

        //output
        private void btnShow_Click(object sender, EventArgs e)
        {
            labShowProduct.Text += productResult;
        }
    }
}
