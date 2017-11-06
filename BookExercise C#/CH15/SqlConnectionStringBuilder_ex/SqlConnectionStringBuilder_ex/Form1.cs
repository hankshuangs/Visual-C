using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ADO.NET for SQL Server
namespace SqlConnectionStringBuilder_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //查詢
        private void btn_Query_Click(object sender, EventArgs e)
        {
            string SelectCmd = "";
            string keyword = "";
            keyword = txt_Std_IdName.Text;

            SelectCmd = "Select std_id as 學號 , std_name as 姓名 , " +
                "computer as 電腦 , english as 英文 , math as 數學 , " +
                "computer + english + math as 三科總分 From grades " +
                "Where std_id Like '" + keyword + "%' Or std_name Like '" +
                keyword + "%' Order by 三科總分 DESC";

            dataGridView1.DataSource = CreateDataTable(SelectCmd, "grades");
            dataGridView1.AutoResizeColumns();
        }

        //建立DataTable
        public DataTable CreateDataTable(string SQLcmd, string TableName)
        {
            try
            {
                string ConnString;

                SqlConnectionStringBuilder Builder = new
                      SqlConnectionStringBuilder();
                Builder.DataSource = "127.0.0.1";
                Builder.InitialCatalog = "SchoolExam";
                Builder.UserID = "sa";
                Builder.Password = "12345";
                Builder.IntegratedSecurity = true;
                Builder.ConnectTimeout = 30;

                ConnString = Builder.ConnectionString;

                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(SQLcmd, conn);

                DataSet ds = new DataSet();
                da.Fill(ds, TableName);

                conn.Close();
                da.Dispose();

                //回傳DataTable
                return ds.Tables[TableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外訊息");
                return null;
            }
        }
    }
}
