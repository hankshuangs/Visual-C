using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goto_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            string msg = "";
            string[] password = new string[5] { "123", "321", "abc", "xyz", "guest" };

            for (i = 0; i < password.Length; i++)
            {
                j = i + 1;
                if (txtPwd.Text == password[i])
                {
                    goto Found;
                }

            }
            goto NotFound;

        Found:
            msg = "密碼正確,迴圈共執行" + j.ToString() + "次";
            goto Finish;

        NotFound:
            msg = "[" + txtPwd.Text + "]密碼錯誤";

        Finish:
            MessageBox.Show(msg, "執行完畢");
        }
    }
}
