using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectInitalizers_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // 物件初始設定式
            Student Kevin = new Student { StdName = "許清榮", Course = "C#", Score = 100 };

            string msg = "";
            msg = msg + "學生姓名:" + Kevin.StdName + "\n";
            msg = msg + "課程名稱:" + Kevin.Course + "\n";
            msg = msg + "分數:" + Kevin.Score;
            MessageBox.Show(msg);
        }
    }
    class Student
    {
        public string StdName { get; set; }
        public string Course { get; set; }
        public int Score { get; set; }
    }
}
