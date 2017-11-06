using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SealedClass_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    class SportCar : SuperSportCar
    {
    }
    sealed class SuperSportCar //宣告SuperSportCar為密封類別
    {
        public string Name { get { return "Bugatti Veyron"; } }
        public int Horsepower { get { return 1000; } }
        public double Torque { get { return 77.5; } }
        public int MaxSpeed { get { return 407; } }
        public SuperSportCar()
        {
            string msg = "[布佳迪威龍]是世界上最快的跑車!\n";
            msg = msg + "目前後繼無車，故不能被其他類別繼承!";
            MessageBox.Show(msg, "密封類別範例");
        }
    }
}
