using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyObjectTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string msg = "電腦使用者名稱:" + My.User.Name;
            MessageBox.Show(msg, "My.User");
        }

        private void btnCopyrights_Click(object sender, EventArgs e)
        {
            string msg = "版權宣告:" + My.Copyrights.GetCopyrightInfo;
            MessageBox.Show(msg, "My.Copyrights");
        }
    }
}
