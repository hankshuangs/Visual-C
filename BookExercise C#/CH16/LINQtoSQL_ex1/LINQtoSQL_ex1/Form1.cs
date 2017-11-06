using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext CPC = new DataClasses1DataContext();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var oilQuery = from listprice in CPC.ListPrice
                           where listprice.ProductName != ""
                           select listprice;

            dataGridView1.DataSource = oilQuery;
        }
    }
}
