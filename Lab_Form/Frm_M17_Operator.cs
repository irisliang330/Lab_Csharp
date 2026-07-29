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

        //18-6 else if - score grade
        private void btnGrade_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);

            if (score >= 90 && score <= 100)
            {
                labGrade.Text = "A";
            }else if (score >=80 && score < 90)
            {
                labGrade.Text = "B";
            }
            else if (score >= 70 && score < 80)
            {
                labGrade.Text = "C";
            }
            else if (score >= 60 && score < 70)
            {
                labGrade.Text = "D";
            }
            else
            {
                labGrade.Text = "E";
            }

        }
    }
}
