using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateMethod_Click(object sender, EventArgs e)
        {
            string msg = "";

            Car AE86 = new Car();

            AE86.Horsepower = 140;
            AE86.Torque = 18.6;
            AE86.MaxSpeed = 200;
            msg = "建立Toyota AE86甩尾跑車\n";
            msg = msg + "馬力:" + AE86.Horsepower + "hp\n";
            msg = msg + "扭力:" + AE86.Torque + "kgm\n";
            msg = msg + "最高時速:" + AE86.MaxSpeed + "km\n";
            msg = msg + "引擎技術:" + AE86.EngineTechnology(false) + "\n";
            msg = msg + "供油系統:" + AE86.FuelSystem("AE86");
            MessageBox.Show(msg, "方法建立範例");
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
