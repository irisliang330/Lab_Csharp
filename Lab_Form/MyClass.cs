using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyClass
    {
        internal void MyNewMethod()
        {
            MessageBox.Show("呼叫不同類別方法");
        }

        void Method01Default() {
            MessageBox.Show("default method is private");
        }

        private void Method02Private() { 
            MessageBox.Show("private method is private");
        }
        internal void Methdod03Internal()
        {
            MessageBox.Show("internal method is internal");
        }

        public void Method04Public()
        {
            MessageBox.Show("public method is public");
        }

        public void Method05CallMethod01And02() {
            
            Method01Default();
            Method02Private();

        }


    }
}
