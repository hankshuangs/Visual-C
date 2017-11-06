using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleInheritance_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SuperVehicle SV = new SuperVehicle();
            string msg = "打造陸海空超級交通工具\n";
            msg = msg + SV.RunFly() + "\n";
            msg = msg + SV.RunShip() + "\n";
            msg = msg + SV.RunDriver();
            MessageBox.Show(msg, "實作多重繼承技巧");
        }
    }

    interface iAirplane { string RunFly(); }
    interface iShip { string RunShip(); }
    interface iCar { string RunDriver(); }
    interface iAllVehicle : iAirplane, iShip, iCar { };
    class SuperVehicle : iAllVehicle
    {
        public string RunFly()
        {
            return "執行空中飛翔動作..";
        }
        public string RunShip()
        {
            return "執行海上划船動作..";
        }
        public string RunDriver()
        {
            return "執行陸地駕駛動作..";
        }
    }
}
