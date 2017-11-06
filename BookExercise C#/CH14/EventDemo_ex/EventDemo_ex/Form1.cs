using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            string msg = "作者個人資訊:\n";
            msg = msg + "姓名:許清榮\n";
            msg = msg + "英文:Ryu";
            MessageBox.Show(msg, "按鈕Click事件");
        }
    }
}
