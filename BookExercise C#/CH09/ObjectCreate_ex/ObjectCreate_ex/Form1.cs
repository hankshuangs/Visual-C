using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectCreate_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFerrari_Click(object sender, EventArgs e)
        {
            string msg = "";

            Car Ferrari430 = new Car();

            Ferrari430.Horsepower = 490;
            msg = "建立Ferrari 430超級跑車\n";
            msg = msg + "馬力:" + Ferrari430.Horsepower + "hp\n";
            msg = msg + "引擎技術:" + Ferrari430.EngineTechnology(false);
            MessageBox.Show(msg, "第一種建立物件方式");
        }

        private void btnPorsche_Click(object sender, EventArgs e)
        {
            string msg = "";

            Car PorscheBoxster;
            PorscheBoxster = new Car();

            PorscheBoxster.Horsepower = 252;
            msg = "建立Porsche Boxster敞篷跑車\n";
            msg = msg + "馬力:" + PorscheBoxster.Horsepower + "hp\n";
            msg = msg + "引擎技術:" + PorscheBoxster.EngineTechnology(true);
            MessageBox.Show(msg, "第二種建立物件方式");
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
