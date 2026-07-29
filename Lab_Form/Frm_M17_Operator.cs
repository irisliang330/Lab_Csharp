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
    public partial class Frm_M17_Operator : Form
    {
        public Frm_M17_Operator()
        {
            InitializeComponent();
        }

        //17-10 operator reverse & flag control

        //flag control
        bool flag = true;
        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btnReverse.BackColor = Color.Blue;
                //flag = false;
            }
            else
            {
                btnReverse.BackColor = Color.Red;
                //flag = true;
            }

            //17-4 reverse
            flag = !flag;
        }

        //17-3 Tenary Operator
        private void btnTenary_Click(object sender, EventArgs e)
        {
            btnTanary.BackColor = flag? Color.Blue : Color.Red;
            flag = !flag;
        }
    }
}
