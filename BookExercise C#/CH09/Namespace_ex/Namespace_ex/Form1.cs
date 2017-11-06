using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namespace_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            Vehicle.Car.SportCar Eclipse = new Vehicle.Car.SportCar();
            Eclipse.Name = "Mitsubishi Eclipse-三菱日蝕";
            Eclipse.Horsepower = 205;
            string msg = "車種:" + Eclipse.Name + "\n";
            msg = msg + "馬力:" + Eclipse.Horsepower + "匹";
            MessageBox.Show(msg, "命名空間範例");
        }
    }
}
namespace Vehicle
{
    namespace Car
    {
        public class SportCar  //跑車
        {
            public string Name { get; set; }
            public int Horsepower { get; set; }

            public string EngineTechnology(bool isTurbo)
            {
                if (isTurbo)
                {
                    return "渦輪增壓(Turbo)";
                }
                else
                {
                    return "自然進氣(Natural Aspirate)";
                }
            }
        }
        public class Convertible { } //敞篷車
        public class SUVs { } //Sport Utility Vehicles休旅車
    }
    namespace Train { class MagLev { } } //火車-磁浮火車
    namespace Airplane { class Airsuperiority { } } //飛機-戰鬥機
}

