using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTurbo_Click(object sender, EventArgs e)
        {
            string msg = "";

            SportCar Eclipse = new SportCar();

            Eclipse.Horsepower = 205;
            Eclipse.Torque = 30.4;
            Eclipse.MaxSpeed = 220;
            Eclipse.UseTurbo();//啟動渦輪加速

            msg = "建立Mitsubishi Eclipse 2014競速跑車\n";
            msg = msg + "馬力:" + Eclipse.Horsepower + "hp\n";
            msg = msg + "扭力:" + Eclipse.Torque + "kgm\n";
            msg = msg + "最高時速:" + Eclipse.MaxSpeed + "km\n";
            msg = msg + "引擎技術:" + Eclipse.EngineTechnology(true) + "\n";
            msg = msg + "供油系統:" + Eclipse.FuelSystem("Eclipse");
            MessageBox.Show(msg, "類別繼承範例");
        }
    }
    class SportCar : Car
    {
        public void UseTurbo()
        {
            Horsepower = Horsepower * 2;
            Torque = Torque * 2;
            MaxSpeed = MaxSpeed + 100;
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
                if (value >= 0 && value <= 400)
                {
                    this.maxSpeed = value;
                }
                else if (value < 0)
                {
                    this.maxSpeed = 0;
                }
                else if (value > 400)
                {
                    this.maxSpeed = 400;
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

        /// <summary>
        /// 建立供油方式-方法
        /// </summary>
        /// <param name="carName">傳入汽車名稱</param>
        /// <returns>回傳字串值</returns>
        public string FuelSystem(string carName)
        {
            if (carName == "AE86")
            {
                return "化油器(Carburetor)";
            }
            else
            {
                return "多點噴射(Multi-Port Fuel Injected)";
            }
        }
    }

}
