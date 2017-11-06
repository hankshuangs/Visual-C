using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int counter = 0;

            while (counter < 10)
            {
                counter = counter + 1;
            }

            MessageBox.Show("while迴圈共執行[" + counter + "]次");
        }
    }
}
