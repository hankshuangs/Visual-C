using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            char c1 = 'M';
            msg = msg + "字串常值宣告" + c1.ToString() + "\n";
            char c2 = (char)77;
            msg = msg + "Cast十進位轉換宣告" + c2.ToString() + "\n";
            char c3 = '\x4D';
            msg = msg + "十六進位轉換宣告" + c3.ToString() + "\n";
            char c4 = '\u004D';
            msg = msg + "Unicode宣告" + c4.ToString();
            MessageBox.Show(this, msg, "字元宣告方式");
        }
    }
}
