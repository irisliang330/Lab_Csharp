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
    public partial class Frm_M19_Array : Form
    {
        public Frm_M19_Array()
        {
            InitializeComponent();
        }

        //19-7 Array
        private void btnArray_Click(object sender, EventArgs e)
        {
            //19-7 create Array
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            //19-8-1 array initialize-1
            int[] arrInitialize01 = new int[3] { 1, 2, 3 };

            //19-8-2 array initialize-2
            int[] arrInitialize02 = { 1, 2, 3 };

            string resultArr = "";

            //using for
            for (int i = 0; i < arr.Length; i++)
            {
                resultArr += arr[i] + "\n";
            }

            //using foreach
            foreach (int i in arrInitialize01)
            {
                resultArr += i + "\n";
                //foreach 會把 arr 元素值依序放進i
                //i不是index
                //寫 += arr[i] 會 out of exception
            }

            MessageBox.Show(resultArr);
        }
    }
}
