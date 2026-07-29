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
            btnTanary.BackColor = flag ? Color.Blue : Color.Red;
            flag = !flag;
        }


        private void btnGrade_Click(object sender, EventArgs e)
        {
            //int score = int.Parse(txtScore.Text);
            bool isNumUnder100 = false;
            int score = 0;

            //todo try Parse
            if (int.TryParse(txtScore.Text, out int result) && result >= 0 && result <= 100)

                if (isNumUnder100)
                {
                    score = int.Parse(txtScore.Text);
                }
                else
                {
                    MessageBox.Show("請輸入0~100的數字");
                    txtScore.Clear();
                    txtScore.Focus();
                    isNumUnder100 = false;
                }

            //todo 18-6 else if - score grade

            if (score >= 90 && score <= 100)
            {
                labGrade.Text = "A";
            }
            else if (score >= 80 && score < 90)
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

            ////todo 18-9 switch 寫法

            //int scoreSW = 0;
            //switch (scoreSW)
            //{
            //    case A:
            //        labGrade.Text = "A";
            //        break;

            //    case B:
            //        labGrade.Text = "B";
            //        break;
            //    case C:
            //        labGrade.Text = "C";
            //        break;
            //    case D:
            //        labGrade.Text = "D";
            //        break;
            //    case E:
            //        labGrade.Text = "E";
            //        break;
            //}
        }

        // 18-11 while

        int i = 10;
        string result = "";
        private void btnWhile_Click(object sender, EventArgs e)
        {

            while (i<10)
            {
                result += i + "\n";
                i++;
            }
            MessageBox.Show(result);
        }
        
        // 18-13 do while
        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            do
            {
                result += i + "\n";
                i++;
            }
            while (i<10);

            MessageBox.Show(result);
        }
    }
}
