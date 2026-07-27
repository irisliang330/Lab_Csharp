using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_Form
{
    public class MyStyledButton : Button
    {
        public MyStyledButton()
        {
            this.BackColor = Color.LightBlue;
            this.ForeColor = Color.Navy;
            this.Font = new Font("微軟正黑體", 12F, FontStyle.Regular);
        }
    }
}
