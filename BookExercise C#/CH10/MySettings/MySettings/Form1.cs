using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectionString_Click(object sender, EventArgs e)
        {
            //新增設定檔叫用方式
            string ConnectionString = "";
            ConnectionString = Settings1.Default.sqlConnectionString;
            MessageBox.Show(ConnectionString, "SQL Server連線字串");
        }

        private void btnCopyrights_Click(object sender, EventArgs e)
        {
            //原專案設定檔叫用方式
            string Copyrights = "";
            Copyrights = MySettings.Properties.Settings.Default.CompanyCopyrights;
            MessageBox.Show(Copyrights, "版權宣告");
        }
    }
}
