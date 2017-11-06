using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringAlign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendFormat("[{0,-5}]", 99); //靠左對齊
            SB.AppendLine();
            SB.AppendFormat("[{0,5}]", 88); //靠右對齊
            MessageBox.Show(SB.ToString(), "AppendFormat()方法");
        }
    }
}
