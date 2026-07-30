using System;
using System.Collections;
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
    public partial class Frm_M22_List : Form
    {
        public Frm_M22_List()
        {
            InitializeComponent();
        }

        //22-10 List<T>
        List<Employee> lEmployee = new List<Employee>();
        Employee employee = new Employee();

        //add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            employee.EName = txtEmployeeName.Text;

            if (int.TryParse(txtEmployeeAge.Text, out int age))
            {
                employee.EAge = age;
            }
            else
            {
                MessageBox.Show("年齡請輸入數字");
                txtEmployeeAge.Clear();
                txtEmployeeAge.Focus();
            }

            if (int.TryParse(txtEmployeeID.Text, out int eID))
            {
                employee.EID = eID;
            }
            else
            {
                MessageBox.Show("ID請輸入數字");
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
            }

            lEmployee.Add(employee);
            btnShow.PerformClick();
        }

        //show
        private void btnShow_Click(object sender, EventArgs e)
        {
            labEmployeeData.Text = "員工資料";

            for (int i = 0; i < lEmployee.Count; i++)
            {
                labEmployeeData.Text +=
                    $"\n員工姓名:{lEmployee[i].EName} " +
                    $"\n員工年齡:{lEmployee[i].EAge} " +
                    $"\n員工ID:{lEmployee[i].EID}";
            }
        }

        //insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            lEmployee.Insert(0, employee);
            btnShow.PerformClick();
        }

        //clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            lEmployee.Clear();
            btnShow.PerformClick();
        }

        //remove at
        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lEmployee.RemoveAt(0);
            btnShow.PerformClick();
        }

        //add different type elements : error
        //private void btnAddDiffType_Click(object sender, EventArgs e)
        //{
        //    lEmployee.Add("addString");
        //    lEmployee.Add(101010);
        //}
    }
}
