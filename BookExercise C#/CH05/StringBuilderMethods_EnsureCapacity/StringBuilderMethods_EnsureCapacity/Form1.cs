using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_EnsureCapacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "Come what may!";
            StringBuilder SB = new StringBuilder(s1);
            int oldCapacity = SB.Capacity;

            SB.EnsureCapacity(100);

            int newCapacity = SB.Capacity;
            string msg = "[" + s1 + "]容量為=" + oldCapacity + "\n";
            msg = msg + "指定後容量為=" + newCapacity;
            MessageBox.Show(msg, "EnsureCapacity()方法");
        }
    }
}
