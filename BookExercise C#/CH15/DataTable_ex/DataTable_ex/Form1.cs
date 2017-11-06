using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // ADO.NET for SQL Server
namespace DataTable_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string ConnString;
            ConnString = "Data Source =127.0.0.1;Initial catalog = Music;" +
                                "User id = sa;Password = 12345";

            string selectCmd = "select * from Title";

            dataGridView1.DataSource = CreateDataTable(selectCmd, "Title", ConnString);
            dataGridView1.AutoResizeColumns();
        }

        public DataTable CreateDataTable(string SQLcmd, string TableName, string ConnString)
        {
            try
            {
                //Step 1：開啟資料庫連接，準備與資料庫進行溝通和存取
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                // Step 2：資料配接器的宣告，來執行SQL敘述並開啟資料庫連接
                SqlDataAdapter da = new SqlDataAdapter(SQLcmd, conn);

                // Step 3：宣告DataSet，用DataAdapter將SQL執行結果指定資料表填入DataSet中
                DataSet ds = new DataSet();
                da.Fill(ds, TableName);

                conn.Close();
                da.Dispose();

                //回傳DataTable
                return ds.Tables[TableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        private void btnManual_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MakeTable();
        }

        public DataTable MakeTable()
        {
            DataTable table = new DataTable("Product");


            //建立三個DataColumn並設定相關欄位屬性
            DataColumn column1 = new DataColumn("產品編號");
            column1.DataType = System.Type.GetType("System.String");
            column1.AllowDBNull = false;
            column1.Caption = "ProductID";
            column1.DefaultValue = "113F 5100100";

            DataColumn column2 = new DataColumn("產品名稱");
            column2.DataType = System.Type.GetType("System.String");
            column2.AllowDBNull = true;
            column2.Caption = "ProductName";
            column2.DefaultValue = "超級柴油";

            DataColumn column3 = new DataColumn("價格");
            column3.DataType = System.Type.GetType("System.Decimal");
            column3.AllowDBNull = true;
            column3.Caption = "Price";
            column3.DefaultValue = 30.5;


            //將欄位加入表格中
            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);

            //建立三個DataRow並給定其對應欄位內容值
            DataRow row;
            row = table.NewRow();
            row["產品編號"] = "113F 1209800";
            row["產品名稱"] = "98無鉛汽油";
            row["價格"] = 37.1;
            table.Rows.Add(row);


            row = table.NewRow();
            row["產品編號"] = "113F 1209500";
            row["產品名稱"] = "95無鉛汽油";
            row["價格"] = 35.1;
            table.Rows.Add(row);

            row = table.NewRow();
            row["產品編號"] = "113F 1209200";
            row["產品名稱"] = "92無鉛汽油";
            row["價格"] = 33.6;
            table.Rows.Add(row);

            return table;

        }

    }
}
