using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum SuperStar : short
        {
            Jacky = 1,
            Aaron = 2,
            Andy = 3,
            Leon = 4
        };
        private void btnShow_Click(object sender, EventArgs e)
        {
            short Num = 0;
            if (cboNum.Text != "")
            {
                Num = short.Parse(cboNum.Text);
            }

            switch (Num)
            {
                case (short)SuperStar.Jacky:
                    MessageBox.Show("張學油", "割神");
                    break;
                case (short)SuperStar.Aaron:
                    MessageBox.Show("鍋腹城", "武王");
                    break;
                case (short)SuperStar.Andy:
                    MessageBox.Show("劉得滑", "隱帝");
                    break;
                case (short)SuperStar.Leon:
                    MessageBox.Show("離民", "妄子");
                    break;
                default:
                    MessageBox.Show("數值不在範圍內", "列舉範例");
                    break;
            }
        }
    }
}
