using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //當被實體化時，便會自動執行Employee()建構函式
            Employee emp1 = new Employee();
            Employee emp2 = new Employee("許清榮", "專案經理", 80000);
        }
    }
    public class Employee
    {
        public Employee()
        {
            MessageBox.Show("1.無參數建構函式已被執行!", "建構函式");
        }

        public Employee(string name, string position, int salary)
        {
            string msg = "2.多參數建構函式已被執行!\n";
            msg = msg + "員工:" + name + ",職位:" + position;
            msg = msg + ",薪水:" + salary;
            MessageBox.Show(msg, "建構函式");
        }
    }
}
