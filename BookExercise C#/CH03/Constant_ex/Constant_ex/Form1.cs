using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constant_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const double PI = 3.14;
        private void btnConstant_Click(object sender, EventArgs e)
        {
            double circle;//圓周長
            int radius = 100;//半徑
            circle = radius * 2 * Constant_ex.Form1.PI;//圓周長計算
            const string BALLOON = "大氣球";
            MessageBox.Show(BALLOON +
                "圓周長為:[" + circle + "]公分", "常數範例");
        }
    }
}
