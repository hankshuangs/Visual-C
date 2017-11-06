using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goto_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sex = "";

            sex = cboSex.Text;
            double height, weight = 0;
            height = double.Parse(txtHeight.Text);


            switch (sex)
            {
                case "男人":
                    weight = (height - 80) * 0.7;

                    break;
                case "女人":
                    weight = (height - 70) * 0.6;
                    break;
                case "男女":
                    MessageBox.Show("請選擇[男人]或[女人]");
                    break;
                default:
                    goto case "男女";
            }

            MessageBox.Show("您的標準體重=" + weight, sex);
        }
    }
}
