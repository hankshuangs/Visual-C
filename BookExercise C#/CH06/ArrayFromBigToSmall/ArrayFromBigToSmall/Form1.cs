using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFromBigToSmall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] fruit = { "banana", "apple", "strawberry" };

            Array.Sort<string>(fruit);
            Array.Reverse(fruit);

            string msg = "fruit陣列內容值為:\n";
            foreach (var obj in fruit)
            {
                msg = msg + obj + "\n";
            }
            MessageBox.Show(msg, "Array.Sort()方法");
        }
    }
}
