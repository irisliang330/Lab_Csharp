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
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_HelloForm hello = new Frm_HelloForm();
            hello.Show();
        }
    }
}
