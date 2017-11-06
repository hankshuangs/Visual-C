using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsOperators_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            object obj = new Car();
            if (obj is Motorcycle)
            {
                MessageBox.Show("obj是屬於Motorcycle類別");
            }
            else
            {
                MessageBox.Show("obj是不屬於Motorcycle類別");
            }
        }
    }
    class Car { }
    class Motorcycle { }
}
