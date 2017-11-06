using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessModifiers_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Child son = new Child();
            son.GetName();
        }
    }
    class Parent
    {
        protected string GetLastName() { return "許"; }
    }

    class Child : Parent
    {
        public void GetName()
        {
            string fullname = GetLastName() + "清榮";
            MessageBox.Show(fullname, "您的姓名");
        }
        private void GetHeight() { }
        protected void GetWeight() { }
    }
}
