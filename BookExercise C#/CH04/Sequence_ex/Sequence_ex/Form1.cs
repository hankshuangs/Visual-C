using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequence_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double litre, oilPrice;

            litre = double.Parse(txtlitre.Text);

            oilPrice = litre * 34.9;

            MessageBox.Show("共需 " + oilPrice.ToString()
                + " 元", "油價計算結果");
        }
    }
}
