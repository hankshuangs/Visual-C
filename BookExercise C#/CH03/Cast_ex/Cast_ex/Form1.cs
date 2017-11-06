using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cast_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            double FM = 99.9;
            float Radio;
            Radio = (float)FM;
            MessageBox.Show("無線電頻道:" + Radio, "Cast轉型範例");
        }
    }
}
