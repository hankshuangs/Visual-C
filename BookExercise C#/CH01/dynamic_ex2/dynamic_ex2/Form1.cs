using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            TestClass tc = new TestClass();

            MessageBox.Show(tc.TestMethod("LOVE").ToString());
        }
    }

    class TestClass
    {
        static dynamic field;
        dynamic prop { get; set; }

        public dynamic TestMethod(dynamic dyn)
        {
            dynamic var = "區域變數";
            int num = 10;
            field = 1.5;

            if (dyn is string)
            {
                return var;
            }
            else
            {
                return num;
            }
        }
    }
}
