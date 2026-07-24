using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    internal class MyClass
    {
        internal void MyNewMethod()
        {
            MessageBox.Show("呼叫不同類別方法");
        }

        void Methdo01Default() {
            MessageBox.Show("default method is private");
        }

        private void Methdo02Private() { 
            MessageBox.Show("private method is private");
        }
        internal void Methdo03Internal()
        {
            MessageBox.Show("internal method is internal");
        }

        public void Methdo04Public()
        {
            MessageBox.Show("public method is public");
        }

        public void Methdo05CallMethod01And02() {
            
            Methdo01Default();
            Methdo02Private();

        }

    }
}
