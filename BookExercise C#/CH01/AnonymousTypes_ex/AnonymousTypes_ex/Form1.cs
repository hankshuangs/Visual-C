using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousTypes_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowEmployeeInfo_Click(object sender, EventArgs e)
        {
            var employee = new
            {
                EmpID = "A102001",
                Name = "許清榮",
                Sex = '男',
                Ages = 28,
                Status = true
            };

            string msg = "";
            msg = msg + "員工編號:" + employee.EmpID + "\n";
            msg = msg + "姓名:" + employee.Name + "\n";
            msg = msg + "性別:" + employee.Sex + "\n";
            msg = msg + "年齡:" + employee.Ages + "\n";
            msg = msg + "在職狀態:" + employee.Status;

            MessageBox.Show(msg, "員工個人資訊");
        }
    }
}
