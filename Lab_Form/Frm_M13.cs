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
    public partial class Frm_M13 : Form
    {
        public Frm_M13()
        {
            InitializeComponent();
        }

        //13-3 Value Type
        private void btnValueType_Click(object sender, EventArgs e)
        {
            int A = 100; int B = 200; int C = B;
            MessageBox.Show($"A:{A} B:{B} C:{C}");
            B = 300;
            MessageBox.Show($"A:{A} B:{B} C:{C}");
        }

        //13-5 Reference Type
        //observe in designer.cs
        //this.txtReferenceType = new System.Windows.Forms.TextBox();
        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;
            tb.ForeColor = Color.Brown;
            tb.BackColor = Color.LightYellow;
            tb.Text = "color changed";
        }



        //14-4 pass by reference
        private void btnPassByReference_Click(object sender, EventArgs e)
        {
            //using MemberData in Utility.cs
            MemberData memberTestRef = new MemberData()
            {
                Name = "Hiroshi",
                BirthDate = new DateTime(2016, 7, 28),
                PhoneNumber = "0900728728"
            };

            //output01
            MessageBox.Show($"Name:{memberTestRef.Name} Phone: {memberTestRef.PhoneNumber} BirthDate:{memberTestRef.BirthDate.ToShortDateString()}");

            PassByReference(memberTestRef); //2016 to 2006

            //output02 -10 years = 2006
            MessageBox.Show($"Name:{memberTestRef.Name} Phone: {memberTestRef.PhoneNumber} BirthDate:{memberTestRef.BirthDate.ToShortDateString()}");
        }

        void PassByReference(MemberData memberRef)
        {
            memberRef.BirthDate = DateTime.Now.AddYears(-20); //2026-20 = 2006
        }


        //14-3 pass by Value
        private void btnPassByValueType_Click(object sender, EventArgs e)
        {
            int A = 90;
            MessageBox.Show($"A: {A}");
            PassByValue(A);
            MessageBox.Show($"A: {A}"); //A=90
        }

        void PassByValue(int x)
        {
            x = 100;
        }

        // 14-5 Pass By ref
        private void btnPassByRef_Click(object sender, EventArgs e)
        {
            int A = 900;
            MessageBox.Show($"A: {A}");
            PassByRef(ref A);
            MessageBox.Show($"A: {A}"); //A=10
        }

        void PassByRef(ref int x)
        {
            x = 10;
        }

        // 14-5 Pass By out
        private void btnPassByOut_Click(object sender, EventArgs e)
        {
            int A = 300;
            int B = 200;
            PassByOut(out A,out B);
            MessageBox.Show($"A = {A} B= {B}"); //A=600
        }

        void PassByOut(out int x, out int y)
        {
            x = 600;
            y = 500;
            MessageBox.Show($"x = {x}"); //x=600
        }

        // 14-9 Using Params
        private void btnUsingParams_Click(object sender, EventArgs e)
        {
            string chineseTotalScore = CalculateTotalScore("國文", 100, 80, 70);
            MessageBox.Show(chineseTotalScore);

            string mathTotalScore = CalculateTotalScore("數學", 50, 90, 50, 80);
            MessageBox.Show(mathTotalScore);
        }

        string CalculateTotalScore(string course,params int[] scores)
        {
            int totalScore = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                totalScore += scores[i];
            }

            return $"{course}的總成績: {totalScore} 分";
        }
    }
}
