using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisBase_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Child son = new Child("實體化Child類別為son物件");
            son.demo();
        }
    }
    class Parent
    {
        public Parent(string msg)
        {
            MessageBox.Show("父類別-有參數的建構方法\n" + msg, "Parent類別");
        }

        public int N1;
        private float N2;
        protected double N3;
        internal byte N4;
        long N5;

        public virtual string Method1()
        {
            return "父類別-公有(public)方法";
        }

        private string Method2()
        {
            return "父類別-私有(private)方法";
        }

        protected string Method3()
        {
            return "父類別-保護(protected)方法";
        }

        internal string Method4()
        {
            return "父類別-內部(internal)方法";
        }

        string Method5()
        {
            return "父類別-沒有宣告任何存取修飾詞方法";
        }

    }

    class Child : Parent
    {
        public Child(string msg)
            : base(msg + "->傳給父類別訊息")
        {
            MessageBox.Show("子類別-有參數的建構方法\n" + msg, "Child類別");
        }

        public void demo()
        {
            this.N1 = 100;
            //this.N2子類別沒有繼承父類別的private欄位
            this.N3 = 2.5;
            this.N4 = 20;
            //this.N5沒有存取修飾詞欄位預設為private
            string msg = "子類別this可以存取到public方法->" + this.Method1() + "\n";
            msg = msg + "子類別this可以存取到protected方法->" + this.Method3() + "\n";
            msg = msg + "子類別this可以存取到internal方法->" + this.Method4() + "\n";
            msg = msg + "子類別base可以存取到父類別的public方法->" + base.Method1() + "\n";
            msg = msg + "子類別base可以存取到父類別的protected方法->" + base.Method3() + "\n";
            msg = msg + "子類別base可以存取到父類別的internal方法->" + base.Method4() + "\n";
            MessageBox.Show(msg, "this和base使用範例");
        }

        public override string Method1()
        {
            return "子類別-公有(public)方法";
        }
    }
}
