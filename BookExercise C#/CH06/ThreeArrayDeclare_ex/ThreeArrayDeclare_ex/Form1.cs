using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeArrayDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int[, ,] xyz = new int[2, 3, 4]
            {
              { {1,2,3,4},{5,6,7,8},{9,10,11,12} },
              { {13,14,15,16},{17,18,19,20},{21,22,23,24} }
            };

            string msg = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        msg = msg + xyz[i, j, k] + " ";
                    }
                    msg = msg + " , ";
                }
                msg = msg + "\n";
            }
            MessageBox.Show(msg, "三維陣列宣告");
        }
    }
}
