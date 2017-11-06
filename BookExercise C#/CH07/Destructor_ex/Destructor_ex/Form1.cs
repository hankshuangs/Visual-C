using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destructor_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Close();
        }
    }
    public class Employee
    {
        public Employee()
        {
            string msg = "啟動建構函式!!物件建立完成..";
            MessageBox.Show(msg, "建構函式");
        }

        ~Employee()
        {
            string msg = "啟動解構函式!!物件資源釋放完成..";
            MessageBox.Show(msg, "解構函式");
        }
    }
}
