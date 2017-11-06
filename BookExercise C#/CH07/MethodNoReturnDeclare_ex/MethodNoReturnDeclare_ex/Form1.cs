using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodNoReturnDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 無回傳值方法宣告範例 */

        private void NoReturnMethod1() { }

        public static void NoReturnMethod2() { }

        public void NoReturnMethod3(int num, string msg) { }

        protected void NoReturnMethod4() { }

        internal void NoReturnMethod5() { }

        void NoReturnMethod6() { }

        private void Form1_Load(object sender, EventArgs e)  {  }
    }
}
