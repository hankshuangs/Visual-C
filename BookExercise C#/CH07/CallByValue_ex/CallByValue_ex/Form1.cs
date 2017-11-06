using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallByValue_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnByValue_Click(object sender, EventArgs e)
        {
            int N = 99; //N 屬於Primitive data type
            AddNum(N);
            string msg = "傳值呼叫執行結果:\n N=" + N;
            MessageBox.Show(msg, "Call by value");
        }
        private void AddNum(int M)
        {
            M = M + 1;
        }
    }
}
