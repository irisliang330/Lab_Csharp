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

        //Value Type
        private void btnValueType_Click(object sender, EventArgs e)
        {
            int A = 100; int B = 200; int C = B;
            MessageBox.Show($"A:{A} B:{B} C:{C}");
            B = 300;
            MessageBox.Show($"A:{A} B:{B} C:{C}");
        }

        //Reference Type
        //this.txtReferenceType = new System.Windows.Forms.TextBox();
        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;
            tb.ForeColor = Color.Brown;
            tb.BackColor = Color.LightYellow;
            tb.Text = "color changed";
        }

    }
}
