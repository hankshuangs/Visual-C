using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void GenericMethod<T>(T arg)
        {
            if (arg.GetType().ToString() == "System.String")
            {
                MessageBox.Show(arg.ToString(), "執行泛型方法-泛型型別為字串");
            }
            else
            {
                MessageBox.Show(arg.ToString(), "執行泛型方法-泛型型別不為字串");
            }
        }
        private void btnGenericsMethod_Click(object sender, EventArgs e)
        {
            GenericMethod<string>("My name is Ching-Jung Hsu");
            GenericMethod<int>(100);
        }

        private void btnGenericsClass_Click(object sender, EventArgs e)
        {
            SwapClass<int> SC1 = new SwapClass<int>();
            SwapClass<double> SC2 = new SwapClass<double>();

            string msg = "";
            msg = msg + "原先:n1 = 10 , n2 = 20 \n";
            int n1 = 10;
            int n2 = 20;
            SC1.Swap(ref n1, ref n2);
            msg = msg + "交換後:n1 =" + n1 + ", n2 = " + n2 + " \n";

            msg = msg + "原先:m1 = 1.25 , n2 = 6.75 \n";
            double m1 = 1.25;
            double m2 = 6.75;
            SC2.Swap(ref m1, ref m2);
            msg = msg + "交換後:m1 =" + m1 + ", m2 = " + m2 + " \n";

            MessageBox.Show(msg, "執行泛型類別");
        }
    }
    public class SwapClass<T>
    {
        public void Swap<T>(ref T p, ref T s)
        {
            T temp;
            temp = p;
            p = s;
            s = temp;
        }
    }
}
