using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDeclare_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (rdoCar1.Checked == true)
            {
                Car Eclipse = new Car();
                Eclipse.Horsepower = 205;
                msg = "您選擇建立Mitsubishi Eclipse跑車\n";
                msg = msg + "馬力:" + Eclipse.Horsepower + "hp\n";
                msg = msg + "引擎技術:" + Eclipse.EngineTechnology(true);
            }
            else
            {
                Car Fortis = new Car();
                Fortis.Horsepower = 157;
                msg = "您選擇建立Mitsubishi Lancer Fortis房車\n";
                msg = msg + "馬力:" + Fortis.Horsepower + "hp\n";
                msg = msg + "引擎技術:" + Fortis.EngineTechnology(false);
            }
            MessageBox.Show(msg, "類別宣告範例");
        }
    }

    class Car
    {
        private int horsepower; //建立馬力-欄位(Field)

        public int Horsepower //建立馬力-屬性(Property)
        {
            get { return horsepower; }
            set { horsepower = value; }
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
