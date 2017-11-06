using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 200;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            errorProvider1.Icon = System.Drawing.Icon.ExtractAssociatedIcon("stop.ico");

            errorProvider1.SetIconAlignment(txtNum, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconPadding(txtNum, 5);
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (IsNumeric(txtNum.Text))
            {
                errorProvider1.Clear();
                msg = "您輸入[" + txtNum.Text + "]是正確數字.";
                MessageBox.Show(msg, "ErrorProvider範例");
            }
            else
            {
                msg = "您輸入[" + txtNum.Text + "]不是正確數字.";
                errorProvider1.SetError(txtNum, msg);
            }
        }

        private bool IsNumeric(string num)
        {
            //step 1:空字串不為數字
            if (num.Length == 0 || num == "")
            {
                return false;
            }
            char c;
            bool symbol = false;
            for (int i = 0; i < num.Length; i++)
            {
                //從字串中逐一取出字元來加以判斷
                c = Convert.ToChar(num.Substring(i, 1));
                if (char.IsNumber(c) == false) //若不是數字則進行以下判斷動作
                {   //step 2:小數點只有一個才為正確數字
                    if (c == '.')
                    {
                        if (symbol == false)
                        {
                            symbol = true;
                        }
                        else //二個以上小數點不是正確數字
                        {
                            return false;
                        }

                    }
                    else
                    {
                        //step 3:判斷第一個字元為[+]或[-]是合法
                        if (c == '+' || c == '-')
                        {
                            if (i != 0)
                            {
                                return false;
                            }
                        }
                        //step 4:其他非數字字元如@#$%均不為數字
                        else
                        {
                            return false;
                        }
                    }

                }

            }
            return true;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text.Trim();
        }


    }
}
