using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticClass_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Human.Name = "許清榮";
            string msg = Human.Init + "\n個人資訊如下:\n";
            msg = msg + "姓名:" + Human.Name + "\n";
            msg = msg + "動作:" + Human.Riding();
            MessageBox.Show(msg, "靜態類別範例");
        }
    }
    public static class Human
    {
        public static string Init;//靜態欄位
        static Human()
        {
            Init = "靜態類別初始化完畢(靜態建構函式)";
        }

        public static string Name { get; set; } //靜態屬性

        public static string Riding() //靜態方法
        {
            return "騎車環島中...";
        }
    }
}
