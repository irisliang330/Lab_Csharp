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
            labCount.Text = "Count:" + count;
        }
    }
}
