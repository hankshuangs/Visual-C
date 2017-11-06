using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallMethod_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            int sum = addition(20, 80);
            string msg = "20 + 80 = " + sum;
            MessageBox.Show(msg, "同一類別呼叫方法");
        }
        /// <summary>
        /// 執行二數加法
        /// </summary>
        /// <param name="n1">傳入第一個整數值</param>
        /// <param name="n2">傳入第二個整數值</param>
        /// <returns>回傳n1+n2的整數和</returns>
        private int addition(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
