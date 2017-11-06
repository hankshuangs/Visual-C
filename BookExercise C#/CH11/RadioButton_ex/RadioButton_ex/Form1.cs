using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = "";
            string answer1 = "", answer2 = "";

            foreach (var obj in groupBox1.Controls)
            {

                if (obj.GetType().ToString() == "System.Windows.Forms.RadioButton")
                {
                    RadioButton rdo1 = (RadioButton)obj;
                    if (rdo1.Checked == true)
                    {
                        answer1 = rdo1.Text;
                        msg = msg + "第一題:您選擇答案為:" + answer1 + "\n";
                    }
                }

            }

            foreach (var obj in groupBox2.Controls)
            {
                if (obj.GetType().ToString() == "System.Windows.Forms.RadioButton")
                {
                    RadioButton rdo2 = (RadioButton)obj;
                    if (rdo2.Checked == true)
                    {
                        answer2 = rdo2.Text;
                        msg = msg + "第二題:您選擇答案為:" + answer2 + "\n";
                    }
                }

            }

            int total = 0;
            if (answer1 == radioButton4.Text)
            {
                total = total + 50;
            }
            if (answer2 == radioButton7.Text)
            {
                total = total + 50;
            }
            msg = msg + "您的總分為:[" + total + "]分";
            MessageBox.Show(msg, "RadioButton範例");
        }
    }
}
