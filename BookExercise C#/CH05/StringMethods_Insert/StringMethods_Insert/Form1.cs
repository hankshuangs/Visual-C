using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "C# is the best language ";
            string s2 = "in the world.";

            string msg = s1.Insert(s1.Length, s2);

            MessageBox.Show(msg, "Insert()方法");

        }
    }
}
