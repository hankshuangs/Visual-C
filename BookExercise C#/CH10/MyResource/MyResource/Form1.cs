using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyResource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = MyResource.Properties.Resources.MyVN900;
        }

        private void btnAuthorInfo_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg = msg + "作者:" + Resource1.MyName + "\n";
            msg = msg + "休閒旅遊:" + Resource1.MyMotorcycle + "\n";
            msg = msg + "都市通勤:" + Resource1.MyScooter + "\n";
            msg = msg + "擋雨坐騎:" + Resource1.MyCar + "\n";
            this.BackgroundImage = MyResource.Properties.Resources.MyEclipse;
            MessageBox.Show(msg, "資源檔範例");
        }
    }
}
