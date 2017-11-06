using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchFinally_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            bool isNum = isNumeric(txtNum.Text);
            if (isNum == true)
            {
                string msg = "您輸入數值[" + txtNum.Text + "]是數字\n";
                MessageBox.Show(msg, "數值判斷");
            }
        }

        public bool isNumeric(string num)
        {
            bool result = false;
            double n = 0;
            string msg = "";
            try
            {
                n = double.Parse(num);
                result = true;
            }
            catch (Exception ex)
            {
                msg = "您輸入數值[" + num + "]不是數字\n";
                msg = msg + "錯誤訊息:" + ex.Message;
                MessageBox.Show(msg, "數值判斷");
            }
            finally
            {
                msg = "";
                n = 0;
            }
            return result;

        }
    }
}
