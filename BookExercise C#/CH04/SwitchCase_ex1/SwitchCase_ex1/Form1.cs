using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetColor_Click(object sender, EventArgs e)
        {
            int KNumbers;
            if (txtKNum.Text.Length == 0)
            {
                KNumbers = 0;
            }
            else
            {
                KNumbers = int.Parse(txtKNum.Text);
            }


            switch (KNumbers)
            {
                case 3000:
                    MessageBox.Show("黃光", "HID顏色");
                    break;
                case 6000:
                    MessageBox.Show("白光", "HID顏色");
                    break;
                case 10000:
                    MessageBox.Show("藍光", "HID顏色");
                    break;
                default:
                    MessageBox.Show("未知的HID", "警告訊息");
                    break;
            }
        }
    }
}
