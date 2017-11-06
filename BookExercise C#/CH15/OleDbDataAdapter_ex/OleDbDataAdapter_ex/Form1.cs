using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//ADO.NET for Access
namespace OleDbDataAdapter_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnString;
                ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                      Application.StartupPath + "\\Authority.mdb;" +
                      "Jet OLEDB:Database Password=12345";

                string selectCmd = "SELECT * FROM Login";

                //Step 1：開啟資料庫連接，準備與資料庫進行溝通和存取
                OleDbConnection conn = new OleDbConnection(ConnString);
                conn.Open();

                // Step 2：資料配接器的宣告，來執行SQL敘述並開啟資料庫連接
                OleDbDataAdapter da = new OleDbDataAdapter(selectCmd, conn);

                // Step 3：宣告DataSet，用DataAdapter將SQL執行結果指定資料表填入DataSet中
                DataSet ds = new DataSet();
                da.Fill(ds, "Login");

                // Step 4：把DataSet中的資料表拿來當DataGridView控制項的資料來源
                dataGridView1.DataSource = ds.Tables["Login"];

                // Step 5：關閉連接物件與資料配接器物件來釋放物件所佔用的資源
                conn.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "例外資訊");
            }
        }
    }
}
