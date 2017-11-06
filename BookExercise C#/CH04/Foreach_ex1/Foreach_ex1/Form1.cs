using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int count = 0;
            string msg = "";

            string[] student = new string[5];
            student[0] = "Ryu";
            student[1] = "Henry";
            student[2] = "Ken";
            student[3] = "Vera";
            student[4] = "Peggy";

            foreach (var obj in student)
            {
                msg = msg + obj + Environment.NewLine;
                count = count + 1;
            }

            msg = msg + "共有[" + count + "]人";

            MessageBox.Show(msg, "新蛋學院");

        }
    }
}
