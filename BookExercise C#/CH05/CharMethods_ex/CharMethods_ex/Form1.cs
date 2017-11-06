using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharMethods_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (txtChar.Text != "")
            {
                char c = System.Convert.ToChar(txtChar.Text);

                if (char.IsDigit(c) || char.IsNumber(c.ToString(), 0))
                {
                    msg = msg + c.ToString() + " 是十進位數字" + "\n";
                }
                if (char.IsLetter(c))
                {
                    msg = msg + c.ToString() + " 是英文字母" + "\n";
                    if (char.IsLower(c) == true)
                    {
                        msg = msg + c.ToString() + " 是小寫" + "\n";
                        msg = msg + Char.ToUpper(c).ToString() + " 轉換大寫" + "\n";
                    }
                    if (char.IsUpper(c) == true)
                    {
                        msg = msg + c.ToString() + " 是大寫" + "\n";
                        msg = msg + Char.ToLower(c).ToString() + " 轉換小寫" + "\n";
                    }


                }
                if (char.IsPunctuation(c))
                {
                    msg = msg + c.ToString() + " 是標點符號" + "\n";
                }
                if (char.IsSeparator(c))
                {
                    msg = msg + c.ToString() + " 是分隔字元" + "\n";
                }
                if (char.IsSymbol(c))
                {
                    msg = msg + c.ToString() + " 是符號字元" + "\n";
                }
                if (char.IsWhiteSpace(c))
                {
                    msg = msg + c.ToString() + " 是空白字元" + "\n";
                }
                if (char.IsControl(c))
                {
                    msg = msg + c.ToString() + " 是控制字元" + "\n";
                }
            }
            else
            {
                MessageBox.Show("您必須輸入一個字元!");
            }
            MessageBox.Show(msg, "字元判斷");
        }
    }
}
