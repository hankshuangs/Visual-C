using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallByReference_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnByReference_Click(object sender, EventArgs e)
        {
            int[] N = { 99 }; //N 是陣列為Reference data type
            AddNum(N);
            string msg = "傳參考呼叫執行結果:\n N=" + N[0];
            MessageBox.Show(msg, "Call by reference");
        }
        private void AddNum(int[] M)
        {
            M[0] = M[0] + 1;
        }
    }
}
