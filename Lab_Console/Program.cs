using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Frm_HelloForm hello = new Frm_HelloForm();
            //hello.ShowDialog();

            //Console.WriteLine("Hello Csharp !");
            //Console.Write("請輸入姓名:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello ! {name}!");
            //Frm_HelloForm(name);

            //calling MyClass in Lab_Console.Program
            MyClass mc = new MyClass();
            mc.Method04Public();
            mc.Method05CallMethod01And02();
            mc.Method06PartialClass();

        }

        private static void Frm_HelloForm(string name)
        {
            throw new NotImplementedException();
        }
    }
}
