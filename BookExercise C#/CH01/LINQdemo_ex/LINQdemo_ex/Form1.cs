using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQdemo_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Step 2:建立查詢集合物件的資料
            List<ListPrice> listprices = new List<ListPrice>
             {
               new ListPrice {ProductID="113F 1209800", ProductName="98無鉛汽油", Prices=37},
               new ListPrice {ProductID="113F 1209500", ProductName="95無鉛汽油", Prices=35},
               new ListPrice {ProductID="113F 1209200", ProductName="92無鉛汽油", Prices=33.5},
               new ListPrice {ProductID="113F 5100100", ProductName="超級柴油", Prices=32.3}
             };

            //Step 3:使用LINQ查詢語法
            var listPriceQuery =
                   from listprice in listprices
                   where listprice.Prices >= 35
                   select listprice;

            //Step 4:將LINQ查詢結果列印出來
            string msg = "";
            foreach (ListPrice listprice in listPriceQuery)
            {
                msg = msg + listprice.ProductName + "=" + listprice.Prices + "\n";
            }

            MessageBox.Show(msg, "油品價目", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    //Step 1:用類別建立資料表結構
    public class ListPrice
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double Prices { get; set; }
    }

}
