using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseClassDerivedClass_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SportCar sc = new SportCar();
            sc.ShowCarName();
        }
    }

    //宣告Car為父類別
    public class Car
    {
        public string GetCarCompany()
        {
            return "Mitsubishi ";
        }
    }
    //SportCar繼承了父類別Car的一些屬性和方法
    class SportCar : Car
    {
        public void ShowCarName()
        {
            MessageBox.Show(GetCarCompany() + "Eclipse 2014","Car Infomation");
        }
    }
}
