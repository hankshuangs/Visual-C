using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringAttributeLength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string technology;
            technology = "Language Integrated Query";

            MessageBox.Show(technology + "\n字串長度="
                 + technology.Length, "字串屬性Length");
        }
    }
}
