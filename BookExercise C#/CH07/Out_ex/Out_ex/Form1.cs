using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Out_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg; //不需要明確初始化變數

            GetMessage(out msg);

            MessageBox.Show(msg, "out參數範例");
        }
        public void GetMessage(out string news)
        {
            news = "乳酪餅沒乳酪？抽取物、香料調味。";
        }
    }
}
