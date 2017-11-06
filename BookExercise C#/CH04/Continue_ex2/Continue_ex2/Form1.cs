using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Continue_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            int num = 0, modnum = 0, counter = 0;
            num = int.Parse(txtNum.Text);

            for (int i = 1; i <= num; i++)
            {
                modnum = num % i;
                if (modnum != 0)
                {
                    continue;
                }

                counter++;

                if (counter > 2)
                {
                    MessageBox.Show("[" + num + "]並非質數", "質數判斷");
                    break;
                }


            }

            if (counter == 2)
            {
                MessageBox.Show("[" + num + "]是質數", "質數判斷");
            }
        }
    }
}
