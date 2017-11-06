using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemConvert_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string strTelephone;
            int intTeplphone;
            strTelephone = "26962869";

            intTeplphone = System.Convert.ToInt32(strTelephone);
            MessageBox.Show("博碩電話:02-" + intTeplphone, "轉型範例");
        }
    }
}
