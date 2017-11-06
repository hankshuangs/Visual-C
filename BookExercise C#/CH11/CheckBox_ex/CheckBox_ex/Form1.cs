using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox2.ThreeState = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string msg = "您選取的水果為:\n";
            int n = 0;
            foreach (var obj in groupBox1.Controls)
            {
                CheckBox cbx = (CheckBox)obj;
                if (cbx.CheckState == CheckState.Checked)
                {
                    msg = msg + cbx.Text + "\n";
                    n = n + 1;
                }
                else if (cbx.CheckState == CheckState.Indeterminate)
                {
                    msg = msg + cbx.Text + "(不確定)\n";
                    n = n + 1;
                }
            }
            msg = msg + "選取水果總數共:[" + n + "]個";
            MessageBox.Show(msg, "CheckBox範例");
        }

        private void btnAllSelect_Click(object sender, EventArgs e)
        {
            foreach (var obj in groupBox1.Controls)
            {
                CheckBox cbx = (CheckBox)obj;
                cbx.Checked = true;
            }
        }

        private void btnAllUnselect_Click(object sender, EventArgs e)
        {
            foreach (var obj in groupBox1.Controls)
            {
                CheckBox cbx = (CheckBox)obj;
                cbx.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("您選取[蘋果]", "CheckedChanged");
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("您選取[奇異果]", "CheckStateChanged");
            }
            else if (checkBox2.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("不確定[奇異果]", "CheckStateChanged");
            }
            else
            {
                MessageBox.Show("您取消[奇異果]", "CheckStateChanged");
            }
        }
    }
}
