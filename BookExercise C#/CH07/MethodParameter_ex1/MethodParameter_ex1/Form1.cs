using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodParameter_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = GetManProfile("許清榮", 28, '男');

            MessageBox.Show(msg, "個人資料");
        }
        public string GetManProfile(string Name, int Ages, char Sex)
        {
            string s = "姓名:" + Name + "\n";
            s = s + "年齡:" + Ages + "\n";
            s = s + "性別:" + Sex;
            return s;
        }
    }
}
