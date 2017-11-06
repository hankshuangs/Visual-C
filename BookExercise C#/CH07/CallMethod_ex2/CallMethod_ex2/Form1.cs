using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallMethod_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            Cars sportCar = new Cars();//實體化Cars類別為SportCar物件
            string msg = "跑車名稱:" + sportCar.GetCarName() + "\n";
            msg = msg + "馬力:" + sportCar.GetHP();
            MessageBox.Show(msg, "動態方法呼叫");
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            //執行靜態方法不需透過new來對類別進行實體化動作
            string s = FileProcess.ShowMessage();
            FileProcess.CopyFile(s);
        }
    }
    class FileProcess
    {
        public static void CopyFile(string msg)
        {
            MessageBox.Show("進行[檔案拷貝]動作...", msg);
        }
        public static string ShowMessage()
        {
            return "靜態方法呼叫";
        }
    }
    class Cars
    {
        public string GetCarName()
        {
            return "Mitsubishi Eclipse 2014";
        }
        public int GetHP()
        {
            return 280;
        }
    }
}
