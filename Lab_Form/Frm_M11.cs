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
    public partial class Frm_M11 : Form
    {
        public Frm_M11()
        {
            InitializeComponent();
        }

        int count = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {

            count++;
            labCount.Text = $"Count:{count}";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            labCount.Text = $"Count:{count}";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            count *= 2;
            labCount.Text = $"Count:{count}";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            count /= 2;
            labCount.Text = $"Count:{count}";
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            count %= 3;
            labCount.Text = $"Count:{count}";
        }
    }
}
