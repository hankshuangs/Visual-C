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

namespace DataView_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string SelectCmd = "Select TOP 20 * from Title order by 歌曲編號";
            DataView DV = new DataView();
            DV = CreateDataView(SelectCmd, "Title");
            DataGridView1.DataSource = DV;

            //替代資料列樣式
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Ivory;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string FieldName = "";
            string Keyword = "";
            string SortField = "";
            string Sort = "";

            switch (Combo_QueryItem.Text)
            {
                case "歌曲編號":
                    FieldName = "歌曲編號";
                    break;

                case "歌名":
                    FieldName = "歌名";
                    break;

                case "歌手":
                    FieldName = "歌手";
                    break;

                case "語言":
                    FieldName = "語言";
                    break;

                case "發行日期":
                    FieldName = "發行日期";
                    break;

                case "目前名次":
                    FieldName = "目前名次";
                    break;

                default:
                    FieldName = "";
                    break;
            }

            Keyword = txt_keyword.Text;

            switch (Combo_SortItem.Text)
            {
                case "歌曲編號":
                    SortField = "歌曲編號";
                    break;

                case "歌名":
                    SortField = "歌名";
                    break;

                case "歌手":
                    SortField = "歌手";
                    break;

                case "語言":
                    SortField = "語言";
                    break;

                case "發行日期":
                    SortField = "發行日期";
                    break;

                case "目前名次":
                    SortField = "目前名次";
                    break;

                default:
                    SortField = "";
                    break;
            }

            if (rdobtn_ASC.Checked == true)
            {
                Sort = "ASC";
            }
            else
            {
                Sort = "DESC";
            }

            String SQLCommand = "";

            if (FieldName == "")
            {
                SQLCommand = @"Select  * from Title ";
            }
            else
            {
                SQLCommand = @"Select  * from Title Where " + FieldName + @" Like '%" + Keyword + @"%'";
            }

            if (SortField != "")
            {
                SQLCommand = SQLCommand + " order by " + SortField + " " + Sort;
            }

            DataView DV = new DataView();
            DV = CreateDataView(SQLCommand, "Title");
            DataGridView1.DataSource = DV;
        }

        private DataView CreateDataView(string SQLString, string TableName)
        {
            try
            {
                DataView DV = new DataView();

                string ConnString;
                ConnString = "Data Source =127.0.0.1;Initial catalog = Music;" +
                                "User id = sa;Password = 1234";

                //Step 1: 開啟資料庫連接
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                //Step 2:資料配接器宣告,用來執行SQL敘述並且開啟資料庫連接
                SqlDataAdapter da = new SqlDataAdapter(SQLString, conn);
                DataSet ds = new DataSet();

                // Step 3：宣告DataSet，用DataAdapter將SQL執行結果指定資料表填入DataSet中
                da.Fill(ds, TableName);
                DV = ds.Tables[TableName].DefaultView;

                //Step 4:關閉連接物件與資料配接器物件來釋放物件所佔用的資源
                conn.Close();
                conn.Dispose();
                da.Dispose();
                ds.Dispose(); //釋放DataSet物件資源

                return DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + @";請將Music.mdf資料庫檔附加至SQL Server");
                return null;
            }
        }
    }
}