using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //entry point
            //Application.Run(new Frm_M11());
            //Application.Run(new Frm_M13_CTS());
            Application.Run(new Frm_M15_struct("多載"));
            //Application.Run(new Frm_HelloForm());


        }
    }
}
