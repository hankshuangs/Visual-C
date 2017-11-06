using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int i, j;
            int m = 0, n = 0;
            string msg = "";

            for (i = 1; i <= 100; i++)
            {
                if (i > 5)
                { break; }

                m = 0; j = 1;
                while (j <= 100)
                {
                    if (j == 5)
                    { break; }
                    m = m + j;
                    msg = msg + " " + j.ToString() + " ";
                    j++;
                }

                msg = msg + Environment.NewLine;
                n = n + m;

            }

            msg = msg + "總和=" + n.ToString();
            MessageBox.Show(msg, "break範例程式");
        }
    }
}
