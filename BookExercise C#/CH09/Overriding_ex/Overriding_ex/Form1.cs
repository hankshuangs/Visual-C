using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overriding_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Child son = new Child();

            Parent father = new Parent();

            string msg = "";
            msg = msg + "兒子姓名:" + son.FullName() + "\n";
            msg = msg + "身高:" + son.Height.ToString() + ",";
            msg = msg + "血型:" + son.blood + "\n";

            msg = msg + "父親姓名:" + father.FullName() + "\n";
            msg = msg + "身高:" + father.Height.ToString() + ",";
            msg = msg + "血型:" + father.blood;
            MessageBox.Show(msg, "重寫範例");
        }
    }
    class Parent
    {
        public string blood = "O";

        public virtual int Height
        {
            get
            {
                return 170;
            }
        }

        public string LastName()
        {
            return "許";
        }

        public virtual string FirstName()
        {
            return "茂仁";
        }

        public string FullName()
        {
            string result = LastName() + FirstName();
            return result;
        }
    }

    class Child : Parent
    {
        public new string blood = "B";

        public override int Height
        {
            get
            {
                return 178;
            }
        }

        public override string FirstName()
        {
            return "清榮";
        }
    } //end  class Child : Parent
}
