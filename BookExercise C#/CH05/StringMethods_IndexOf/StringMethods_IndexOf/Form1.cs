using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_IndexOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = "My favorite moto is Kawasaki VN900 Classic.";
            string key = "Kawasaki";

            int index = msg.IndexOf(key);

            MessageBox.Show(msg + "\n的[" + key
                + "]索引位置=" + index.ToString());
        }
    }
}
