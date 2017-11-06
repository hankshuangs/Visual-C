using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = "";
            Compute obj = new Compute();

            msg = msg + obj.Add(5, 10) + "\n";
            msg = msg + obj.Add(10, 20, 30) + "\n";
            msg = msg + obj.Add(12.7, 23.9) + "\n";
            msg = msg + obj.Add(6.5, 2.125, 9.25) + "\n";
            int[] nums = { 1, 2, 3, 4, 5 };
            msg = msg + obj.Add(nums) + "\n";
            MessageBox.Show(msg, "多載範例");
        }
    }
    class Compute
    {
        public string Add(int a, int b)
        {
            string result = a.ToString() + "+"
                + b.ToString() + "=" + (a + b);
            return result;
        }

        public string Add(int a, int b, int c)
        {
            string result = a.ToString() + "+" + b.ToString() + "+"
                + c.ToString() + "=" + (a + b + c);
            return result;
        }

        public string Add(double a, double b)
        {
            string result = a.ToString() + "+"
                   + b.ToString() + "=" + (a + b);
            return result;
        }

        public string Add(double a, double b, double c)
        {
            string result = a.ToString() + "+" + b.ToString() + "+"
                    + c.ToString() + "=" + (a + b + c);
            return result;
        }

        public string Add(int[] a)
        {
            string result = "";
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                if (i == a.Length - 1)
                {
                    result = result + a[i].ToString();
                }
                else
                {
                    result = result + a[i].ToString() + "+";
                }
            }
            result = result + " = " + sum;
            return result;
        }

    }
}
