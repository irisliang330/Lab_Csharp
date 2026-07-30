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
    public partial class Frm_M21_Overload : Form
    {
        public Frm_M21_Overload()
        {
            InitializeComponent();
        }

        //21-2 Overload
        private void btnSwapInt_Click(object sender, EventArgs e)
        {
            int intA = 100;
            int intB = 200;

            MessageBox.Show($"A:{intA} B:{intB}");
            Swap(ref intA, ref intB);
            MessageBox.Show($"A:{intA} B:{intB}");

        }

        void Swap(ref int A, ref int B)
        {
            int temp = A;
            A = B;
            B = temp;
        }
        private void btnSwapString_Click(object sender, EventArgs e)
        {
            string stringA = "AAA";
            string stringB = "BBB";

            MessageBox.Show($"A:{stringA} B:{stringB}");
            Swap(ref stringA, ref stringB);
            MessageBox.Show($"A:{stringA} B:{stringB}");
        }

        void Swap(ref string stringA, ref string stringB)
        {
            string temp = stringA;
            stringA = stringB;
            stringB = temp;
        }

        //21-5 Generic
        private void btnGenericSwap_Click(object sender, EventArgs e)
        {
            int A = 100;
            int B = 200;

            string stringA = "AAA";
            string stringB = "BBB";

            MessageBox.Show($"A:{A} B:{B}");
            MessageBox.Show($"A:{stringA} B:{stringB}");
            GenericSwap<int>(ref A, ref B);
            GenericSwap<string>(ref stringA, ref stringB);
            MessageBox.Show($"A:{A} B:{B}");
            MessageBox.Show($"A:{stringA} B:{stringB}");

        }
        void GenericSwap <T>(ref T A, ref T B)
        {
            T temp = A;
            A = B;
            B = temp;
        }

        //21-6 Generic can use many Types
        private void btnGenericSwapOverloda_Click(object sender, EventArgs e)
        {
            int A = 100;
            int B = 200;
            string C = "CCC";
            string D = "DDD";

            MessageBox.Show($"A:{A} B:{B} C:{C} D:{D}");

            GenericSwap<int, string>(ref A, ref B, ref C, ref D);

            MessageBox.Show($"A:{A} B:{B} C:{C} D:{D}");

        }
        void GenericSwap<T1,T2>(ref T1 A, ref T1 B, ref T2 C,ref T2 D)
        {
            T1 temp = A;
            A = B;
            B = temp;

            T2 temp2 = C;
            C = D;
            D = temp2;
        }

        //21-9 Optional param
        void UsingOptionalParam(int Top, string Name, string ID = "A00")
        {

        }

        private void btnOptionalParam_Click(object sender, EventArgs e)
        {

        }
    }
}
