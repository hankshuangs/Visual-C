using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousObjects_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoReturn_Click(object sender, EventArgs e)
        {
            new Human
            {
                Name = "許清榮(Ching-Rung Shiu)",
                Ages = 28
            }.showProfile();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string msg = new Human
            {
                Name = "許清榮(Ching-Jung Hsu)",
                Ages = 28
            }.getProfile();
            MessageBox.Show(msg, "有回傳值方法");
        }
    }
    public class Human
    {
        public string Name { get; set; }
        public int Ages { get; set; }

        public void showProfile()
        {
            string msg = "";
            msg = msg + "姓名:" + Name + "\n";
            msg = msg + "年齡:" + Ages;
            MessageBox.Show(msg, "無回傳值方法");
        }

        public string getProfile()
        {
            string msg = "";
            msg = msg + "姓名:" + Name + "\n";
            msg = msg + "年齡:" + Ages;
            return msg;
        }

    }
}
