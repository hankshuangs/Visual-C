using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            using (Employee emp = new Employee())
            {
                emp.GetInfo();
            }
        }
    }
    public class Employee : IDisposable
    {
        public void GetInfo()
        {
            MessageBox.Show("執行using陳述句敘述區段!", "資訊提示");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            MessageBox.Show("自動呼叫Dispose()方法", "using陳述句");
        }

    }
}
