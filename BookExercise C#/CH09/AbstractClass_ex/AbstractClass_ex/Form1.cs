using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInherit_Click(object sender, EventArgs e)
        {
            string msg = "";

            SportCar AE86 = new SportCar();

            AE86.Horsepower = 200;
            AE86.Torque = 20.9;
            AE86.MaxSpeed = 240;
            AE86.UseTurbo();//啟動渦輪加速

            msg = "建立TOYOTA AE86競速跑車\n";
            msg = msg + "馬力:" + AE86.Horsepower + "hp\n";
            msg = msg + "扭力:" + AE86.Torque + "kgm\n";
            msg = msg + "最高時速:" + AE86.MaxSpeed + "km\n";
            msg = msg + "引擎技術:" + AE86.EngineTechnology(true) + "\n";
            msg = msg + "供油系統:" + AE86.FuelSystem("AE86");
            MessageBox.Show(msg, "類別繼承範例");
        }
    }

    abstract class Car
    {
        private int maxSpeed; //建立最高時速-欄位(Field)
        //不實作程式碼宣告
        public abstract int Horsepower { get; set; } //建立馬力-屬性(Property)

        public abstract void UseTurbo(); //使用渦輪


        //實作程式碼宣告
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

        //建立供油方式-方法
        public virtual string FuelSystem(string carName)
        {
            if (carName == "AE86")
            {
                return "多點噴射(Multi-Port Fuel Injected)";
            }
            else
            {
                return "化油器(Carburetor)";
            }
        }
    }

    class SportCar : Car
    {
        //完成之前未實作方法和屬性
        private int horsepower;
        public override int Horsepower //建立馬力-屬性(Property)
        {
            get { return horsepower; }
            set { this.horsepower = value; }
        }

        public override void UseTurbo()
        {
            Horsepower = Horsepower * 2;
            Torque = Torque * 2;
            MaxSpeed = MaxSpeed + 100;
        }

        //重寫抽象類別方法

        //建立供油方式-方法
        public override string FuelSystem(string carName)
        {
            return "多點噴射(Multi-Port Fuel Injected)";
        }
    }
}
