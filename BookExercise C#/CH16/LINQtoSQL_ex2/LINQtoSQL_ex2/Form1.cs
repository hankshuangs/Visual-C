using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private nCPC.CPC cpc;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string ConnString = "Data Source =127.0.0.1;Initial catalog = CPC;" +
                                "User id = sa;Password = 12345";
            cpc = new nCPC.CPC(ConnString);

            var oilQuery = from listprice in cpc.ListPrice
                           where listprice.ProductName.IndexOf("無鉛") != -1
                           select listprice;

            dataGridView1.DataSource = oilQuery;
        }
    }
}
