using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string regionCode;

            regionCode = cboRegionCode.Text;


            switch (regionCode)
            {
                case "02":
                    MessageBox.Show("台北", "地區");
                    break;
                case "04":
                    MessageBox.Show("台中", "地區");
                    break;
                case "07":
                    MessageBox.Show("高雄", "地區");
                    break;
                default:
                    MessageBox.Show("未知郵遞區號", "警告訊息");
                    break;
            }
        }
    }
}
