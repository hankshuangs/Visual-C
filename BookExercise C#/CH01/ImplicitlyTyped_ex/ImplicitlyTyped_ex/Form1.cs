using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplicitlyTyped_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtStdName.Text == "")
            {
                MessageBox.Show("請輸入查詢字串", "操作提示");
                txtStdName.Focus();
            }
            else
            {
                string[] students = {"Kevin", "Candy", "Kenny","Ken", 
                          "Cindy", "Karen","Wen","Celia","Kelly","Ray","Ryu"};

                var stdQuery =
                    from student in students
                    where student.IndexOf(txtStdName.Text) != -1
                    select student;

                string msg = "";
                int count = 0;

                foreach (var people in stdQuery)
                {
                    msg = msg + people + "\n";
                    count = count + 1;
                }

                if (count == 0)
                {
                    MessageBox.Show("沒有任何符合資料!!", "查詢結果");
                }
                else
                {
                    MessageBox.Show("共找到" + count.ToString()
                       + "筆資料:\n" + msg, "查詢結果");
                }

            }
        }
    }
}
