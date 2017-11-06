using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunLoop_Click(object sender, EventArgs e)
        {
            int x = 20, y = 10;

            do
            {

                MessageBox.Show("雖然 x < y 不成立(false)，" +
                    "但此訊息仍會被顯示出來.", "x = 20 , y = 10");

            } while (x < y);
        }
    }
}
