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
            //int score = 0;

            //輸入控制 try Parse & 0~100

            if (int.TryParse(txtScore.Text, out int score) && score >= 0 && score <= 100)
            {
                //18-6 else if - score grade
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

            }
            else
            {
                MessageBox.Show("請輸入0~100阿拉伯數字");
                txtScore.Clear();
                txtScore.Focus();
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

            while (i < 10)
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
            while (i < 10);

            MessageBox.Show(result);
        }

        //18-15 for loop 01
        private void btnFor01_Click(object sender, EventArgs e)
        {
            string result01 = "";
            
            for (int i = 0; i < 10; i++)
            {
                result01 += i + "\n";
            }

            MessageBox.Show(result01);
        }

        //18-16 for loop 02
        private void btnFor02_Click(object sender, EventArgs e)
        {
            string result02 = "";
            for (int x = 100, y = 10, z = 1; x / y > z; x /= 2, y -= 2 , z++)
            {
                result02 += $"x :{x} \t y:{y}\t z:{z} \n";
            }

            MessageBox.Show(result02);
        }

        //18-18 foreach
        private void btnForeach_Click(object sender, EventArgs e)
        {
            string resultForeach = "";
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in arr)
            {
                resultForeach += i + "\n";
            }

            MessageBox.Show(resultForeach);
        }
    }
}
