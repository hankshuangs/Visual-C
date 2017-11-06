using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Elseif_Else_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            double oilPrice;

            oilPrice = double.Parse(txtoilPrice.Text);

            if (oilPrice > 30)
            {
                MessageBox.Show("搶錢喔", "民意資訊");
            }
            else if (oilPrice > 25)
            {
                MessageBox.Show("尚可接受", "民意資訊");
            }
            else
            {
                MessageBox.Show("非常合理", "民意資訊");
            }
        }
    }
}
