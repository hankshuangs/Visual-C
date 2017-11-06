using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneArrayDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "2013年11月29日的大樂透開獎號碼為:\n";
            int[] lottery = new int[7];

            lottery[0] = 02;
            lottery[1] = 19;
            lottery[2] = 30;
            lottery[3] = 31;
            lottery[4] = 08;
            lottery[5] = 13;
            lottery[6] = 20;

            for (int i = 0; i < lottery.Length; i++)
            {
                msg = msg + lottery[i] + " ";
            }

            MessageBox.Show(msg, "一維陣列宣告");
        }
    }
}
