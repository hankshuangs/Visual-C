using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string msg = "";

            Car Arash = new Car();

            Arash.Horsepower = 550;
            Arash.Torque = 64.2;
            Arash.MaxSpeed = 354;
            msg = "建立Arash AF-10S超級跑車\n";
            msg = msg + "馬力:" + Arash.Horsepower + "hp\n";
            msg = msg + "扭力:" + Arash.Torque + "kgm\n";
            msg = msg + "最高時速:" + Arash.MaxSpeed + "km\n";
            msg = msg + "引擎技術:" + Arash.EngineTechnology(true);
            MessageBox.Show(msg, "屬性建立範例");
        }
    }
    class Car
    {
        private int horsepower; //建立馬力-欄位(Field)
        private int maxSpeed; //建立最高時速-欄位(Field)
        public int Horsepower //建立馬力-屬性(Property)
        {
            get { return horsepower; }
            set { horsepower = value; }
        }

        public double Torque //建立扭力-屬性(Property)
        {
            get;
            set;
        }

        public int MaxSpeed //建立最高時速-屬性(Property)
        {
            get
            {
                return this.maxSpeed;
            }
            set
            {
                if (value >= 0 && value <= 350)
                {
                    this.maxSpeed = value;
                }
                else if (value < 0)
                {
                    this.maxSpeed = 0;
                }
                else if (value > 350)
                {
                    this.maxSpeed = 350;
                }
            }
        }


        //建立引擎技術-方法(Method)
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
}
