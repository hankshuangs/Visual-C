using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoImplementedProperties_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            Car SportCar = new Car();
            SportCar.Name = "Mitsubishi Eclipse";
            SportCar.Horsepower = 205;
            //只能設定不能讀取SportCar.Torque
            SportCar.Torque = 30.4;

            msg = msg + "汽車名稱:" + SportCar.Name + "\n";
            msg = msg + "馬力:" + SportCar.Horsepower;
            MessageBox.Show(msg, "汽車資訊"); 
        }
    }
    class Car
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Horsepower
        {
            get;//可讀
            set;//可寫
        }

        public double Torque
        {
            private get;//不可讀
            set;//可寫
        }
    }
}
