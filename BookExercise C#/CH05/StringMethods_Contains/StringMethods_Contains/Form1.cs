using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_Contains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = "No way to say.";
            string word = "way";
            bool isFind = msg.Contains(word);

            if (isFind == true)
            {
                MessageBox.Show(msg + "\n有包含[" + word + "]關鍵字");
            }
        }
    }
}
