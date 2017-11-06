using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnerClass_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OuterClass.InnerClass1 OI1 =
           new OuterClass.InnerClass1();
            OI1.show();
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            OuterClass.InnerClass2.show();
        }
    }

    class OuterClass
    {
        public class InnerClass1
        {
            public void show()
            {
                string msg = "叫用內部類別公有方法";
                MessageBox.Show(msg, "實體化類別");
            }
        }

        public static class InnerClass2
        {
            public static void show()
            {
                string msg = "叫用靜態內部類別公有方法";
                MessageBox.Show(msg, "靜態類別");
            }
        }
    }
}
