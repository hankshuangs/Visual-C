using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_ToUpper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "linq就是語言整合查詢";

            string s2 = s1.ToUpper();

            string msg = "轉換大寫前:" + s1 + "\n";
            msg = msg + "轉換大寫後:" + s2;
            MessageBox.Show(msg, "ToUpper");
        }
    }
}
