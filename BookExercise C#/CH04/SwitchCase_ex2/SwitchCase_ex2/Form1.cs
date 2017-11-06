using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            char score;
            if (cboScore.Text.Length != 1)
            {
                score = '\0';
            }
            else
            {
                score = char.Parse(cboScore.Text);
            }


            switch (score)
            {
                case 'A':
                    MessageBox.Show("資優班");
                    break;
                case 'B':
                    MessageBox.Show("普通班");
                    break;
                case 'C':
                    MessageBox.Show("牛頭班");
                    break;
                default:
                    MessageBox.Show("未知等級");
                    break;
            }
        }
    }
}
