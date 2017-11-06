using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (rdoCar1.Checked == true)
            {
                iCar Eclipse = new SportCar();
                msg = "建議購買雙門跑車:" + Eclipse.Name + "\n";
                msg = msg + "馬力:" + Eclipse.Horsepower + "hp\n";
                msg = msg + "扭力:" + Eclipse.Torque + "kgm\n";
                msg = msg + "引擎技術:" + Eclipse.EngineTechnology(true) + "\n";
            }
            else
            {
                iCar Boxster = new Convertibles();
                msg = "建議購買雙門跑車:" + Boxster.Name + "\n";
                msg = msg + "馬力:" + Boxster.Horsepower + "hp\n";
                msg = msg + "扭力:" + Boxster.Torque + "kgm\n";
                msg = msg + "引擎技術:" + Boxster.EngineTechnology(false) + "\n";
            }
            MessageBox.Show(msg, "介面實作多型範例");
        }
    }
    //宣告一個汽車介面
    interface iCar
    {
        string Name { get; set; }
        int Horsepower { get; set; }
        double Torque { get; set; }
        string EngineTechnology(bool isTurbo);
    }

    class SportCar : iCar
    {
        private string name = "Mitsubishi Eclipse";
        private int horsepower = 205;
        private double torque = 30.4;
        public string Name //建立車名-屬性
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Horsepower  //建立馬力-屬性
        {
            get { return horsepower; }
            set { this.horsepower = value; }
        }
        public double Torque //建立扭力-屬性
        {
            get { return torque; }
            set { this.torque = value; }
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
    } //       class SportCar : iCar

    class Convertibles : iCar
    {
        private string name = "Porsche Boxster";
        private int horsepower = 252;
        private double torque = 31.1;
        public string Name //建立車名-屬性
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Horsepower  //建立馬力-屬性
        {
            get { return horsepower; }
            set { this.horsepower = value; }
        }
        public double Torque //建立扭力-屬性
        {
            get { return torque; }
            set { this.torque = value; }
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
    } //class Convertibles : iCar
}
