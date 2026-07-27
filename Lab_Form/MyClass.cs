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
        internal void UsingDiffClassMethod()
        {
            MessageBox.Show("呼叫不同類別方法");
        }

        void Method01Default() {
            MessageBox.Show("Method 01 : default method in Class is private");
        }

        private void Method02Private() { 
            MessageBox.Show("Method 02 : private method is private");
        }
        internal void Method03Internal()
        {
            MessageBox.Show("Method 03 : internal method is internal");
        }

        public void Method04Public()
        {
            MessageBox.Show("Method 04 : public method is public");
        }

        public void Method05CallMethod01And02() {

            MessageBox.Show("Method 05 : callout Method 01 & 02");
            Method01Default();
            Method02Private();

        }


    }
}
