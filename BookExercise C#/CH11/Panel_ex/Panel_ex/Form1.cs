using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int count = 0;
            string msg = "您喜愛的課程為:\n";
            foreach (var obj in panel1.Controls)
            {
                CheckBox chx = (CheckBox)obj;
                if (chx.Checked == true)
                {
                    count = count + 1;
                    msg = msg + count + ". " + chx.Text + "\n";
                }
            }
            msg = msg + "總共[" + count + "]種";
            MessageBox.Show(msg, "Panel範例");
        }
    }
}
