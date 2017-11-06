using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  //新增部分
namespace DataGridView_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = null;
            OleDbDataAdapter da = null;
            DataSet ds = null;
            try
            {
                OleDbConnectionStringBuilder Builder =
                    new OleDbConnectionStringBuilder();
                // Builder.Provider = "Microsoft.ACE.OLEDB.12.0";  //for accdb 
                Builder.Provider = "Microsoft.Jet.OLEDB.4.0"; 
                Builder.DataSource = Application.StartupPath + @"\Company.mdb";
                Builder.Add("Jet OLEDB:Database Password", "12345");

                //Step 1: 開啟資料庫連接
                conn = new OleDbConnection(Builder.ConnectionString);
                conn.Open();

                string SQLCommand = "Select * From Employee";

                //Step 2:資料配接器宣告,用來執行SQL敘述並且開啟資料庫連接
                da = new OleDbDataAdapter(SQLCommand, conn);

                //Step 3:用DataAdpater將SQL執行結果填入DataSet元件中
                ds = new DataSet();
                da.Fill(ds, "Employee");

                dataGridView1.DataSource = ds.Tables["Employee"];

            }
            catch (Exception ex)
            {

                MessageBox.Show("錯誤訊息:" + ex.Message, "例外產生");
            }
            finally
            {
                conn.Close();
                da.Dispose();
                ds.Dispose();
            }
        }
    }
}
