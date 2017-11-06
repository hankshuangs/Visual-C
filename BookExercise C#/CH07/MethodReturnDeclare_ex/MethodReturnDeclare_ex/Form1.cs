using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodReturnDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowRun();
        }

        void ShowRun()
        {
            int n = RunAdd(10, 90);
            MessageBox.Show(n.ToString());
            string s = RunAdd("Hi ", "everybody!");
            MessageBox.Show(s);
        }

        /* 需回傳值方法宣告範例 */
        private string GetMessage() { return "DrMaster"; }

        protected static int RunAdd(int n, int m)
        {
            return n + m;
        }

        public static string RunAdd(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
