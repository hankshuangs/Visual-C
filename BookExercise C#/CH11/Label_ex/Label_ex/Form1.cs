using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            string msg = "應用程式路徑:\n" + Application.StartupPath;
            labDemo.AutoEllipsis = true;
            labDemo.AutoSize = false;
            labDemo.Text = msg;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            labDemo.AutoSize = true;
            labDemo.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            labDemo.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            labDemo.ForeColor = Color.White;
        }
    }
}
