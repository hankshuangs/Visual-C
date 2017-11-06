using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//匯入此命名空間

namespace ImportNamespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            if (Information.IsNumeric(txtNum.Text))
            {
                MessageBox.Show("[" + txtNum.Text + "]是數值.",
                    "匯入命名空間");
            }
            else
            {
                MessageBox.Show("[" + txtNum.Text + "]不是數值.",
                   "匯入命名空間");
            }
        }
    }
}
