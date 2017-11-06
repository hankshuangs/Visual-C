using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxingUnboxing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoxing_Click(object sender, EventArgs e)
        {
            int prices = 600;

            object book = (object)prices;//Boxing

            MessageBox.Show(book.ToString(), "執行Boxing動作");
        }

        private void btnUnboxing_Click(object sender, EventArgs e)
        {
            object book = 600;

            int prices = (int)book;//Unboxing

            MessageBox.Show(prices.ToString(), "執行Unboxing動作");
        }
    }
}
