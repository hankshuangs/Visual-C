using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseVBMyObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.ApplicationServices.User NowUser =
             new Microsoft.VisualBasic.ApplicationServices.User();
            NowUser.InitializeWithWindowsUser();
            int IndexPath = NowUser.Name.IndexOf("\\");
            string UserName = NowUser.Name.Substring(IndexPath + 1);
            MessageBox.Show(UserName, "電腦使用者名稱");
        }
    }
}
