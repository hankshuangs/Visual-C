using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamedArgument_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcCalculateBMI_Click(object sender, EventArgs e)
        {
            double N1, N2, N3;
            double w, h;
            w = double.Parse(txtWeight.Text);
            h = double.Parse(txtHeight.Text);

            N1 = BMI(w, h);
            N2 = BMI(weight: w, height: h);
            N3 = BMI(height: h, weight: w);

            MessageBox.Show(N1 + "\n" + N2 + "\n" + N3);
        }
        static double BMI(double weight, double height)
        {
            return (weight) / (System.Math.Pow(height / 100, 2));
        }
    }
}
