using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVulcan_Click(object sender, EventArgs e)
        {
            var LargeHeavyMotorcycle = new
            {
                Name = "Kawasaki VN900 Classic",
                Horsepower = 50,
                Torque = 8,
                Turbo = false
            };

            string msg = "";
            msg = msg + "重機全名:" + LargeHeavyMotorcycle.Name + "\n";
            msg = msg + "馬力:" + LargeHeavyMotorcycle.Horsepower + "\n";
            msg = msg + "扭力:" + LargeHeavyMotorcycle.Torque + "\n";
            msg = msg + "渦輪增壓:" + LargeHeavyMotorcycle.Turbo;

            MessageBox.Show(msg, "重機資訊");
        }
    }
}
