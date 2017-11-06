using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoAnonymousMethods_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void ShowMessage(string msg);
        private void btnRun_Click(object sender, EventArgs e)
        {
            ShowMessage ShowMsg = new ShowMessage(Display);
            ShowMsg("需要額外實作要傳遞的方法參數(具名方法)");
        }
        void Display(string msg)
        {
            MessageBox.Show(msg, "委派技巧");
        }
    }
}
