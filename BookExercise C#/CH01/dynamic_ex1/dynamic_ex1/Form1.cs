using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            dynamic dyn = 10;
            object obj = 10;

            dyn = dyn + 5;
            obj = obj + 5;





            MessageBox.Show(dyn.ToString() + "=" + dyn.GetType());
            MessageBox.Show(obj.ToString() + "=" + obj.GetType());
        }
    }
}
