using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            btnDemo.Text = "確定";
            btnDemo.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btnFlatStyle_Click(object sender, EventArgs e)
        {
            if (btnDemo.FlatStyle == FlatStyle.Popup)
            {
                btnDemo.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btnDemo.FlatStyle = FlatStyle.Popup;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\ok.ico";
            btnDemo.Image = Image.FromFile(filePath);
            btnDemo.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnIsEnabled_Click(object sender, EventArgs e)
        {
            if (btnDemo.Enabled)
            {
                btnDemo.Enabled = false;
            }
            else
            {
                btnDemo.Enabled = true;
            }
        }


    }
}
