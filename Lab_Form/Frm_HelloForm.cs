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
    public partial class Frm_HelloForm : Form
    {
        public Frm_HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            MessageBox.Show($"Hello {name} !");
            this.Text = name;

            //using DialogResult
            this.DialogResult = DialogResult.OK;
        }

        // using Message to catch user's DialogResult
        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("今天星期一嗎?", //1.問題
                "問你喔",                       //2.標題
                MessageBoxButtons.YesNoCancel, //3.按鈕組合
                MessageBoxIcon.Question);      //4.圖示icon

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("你好棒你好聰明");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("很遺憾今天是星期一");
            }
            else
            {
                MessageBox.Show("你就這麼不想跟我說話嗎");
            }

        }

        //test static var
        private void btnTestStaticVar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{StaticLab.staticCount}");
        }
    }
}
