using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderAttribute_MaxCapacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = "CHIU CHIEN CHI";

            StringBuilder SB = new StringBuilder(msg);

            int maxCapacity = SB.MaxCapacity;

            MessageBox.Show("最大容量=" + maxCapacity,
                "MaxCapacity屬性");
        }
    }
}
