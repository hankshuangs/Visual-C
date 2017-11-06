using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionInitializers_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            List<String> SportCar = new List<String>();
            SportCar.Add("GT3000");
            SportCar.Add("Supra");
            SportCar.Add("NSX");
            MessageBox.Show(SportCar[0] + "," + SportCar[1] + "," + SportCar[2], "日系跑車");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            List<String> SportCar =
               new List<String> { "GT3000", "Supra","NSX" };
            MessageBox.Show(SportCar[0] + "," + SportCar[1] + "," + SportCar[2], "日系跑車");
        }
    }
}
