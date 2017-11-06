using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int score;//宣告score為整數靜態變數
        public static string employee;//宣告employee為字串靜態變數

        private void btnShow_Click(object sender, EventArgs e)
        {
            score = 100;
            employee = "許清榮(Ching-Jung Hsu)";

            int ages = 28;
            char sex = '男';
            bool status = true;
            string msg = "";

            msg = msg + "員工姓名:" + employee + "\n";
            msg = msg + "年齡:" + ages + "\n";
            msg = msg + "性別:" + sex + "\n";
            msg = msg + "在職狀態:" + status + "\n";
            msg = msg + "考績:" + score + "分";
            MessageBox.Show(msg, "員工個人資訊");
        }
    }
}
