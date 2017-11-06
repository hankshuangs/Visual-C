using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringAttributeChars
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
            technology = "Windows Presentation Foundation";

            string acronym;
            acronym = technology[0].ToString() +
                technology[8].ToString() + technology[21].ToString();

            MessageBox.Show(technology +
                "\n微軟新技術的縮寫為:" + acronym, "字串屬性Chars");
        }
    }
}
