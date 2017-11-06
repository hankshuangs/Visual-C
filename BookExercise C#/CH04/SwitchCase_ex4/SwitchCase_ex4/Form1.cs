using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bool sex;
            if (rdoBoy.Checked == true)
            {
                sex = true;
            }
            else
            {
                sex = false;
            }


            switch (sex)
            {
                case true:
                    MessageBox.Show("男生", "性別");
                    break;
                case false:
                    MessageBox.Show("女生", "性別");
                    break;
            }
        }
    }
}
