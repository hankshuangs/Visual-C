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
namespace LINQtoDataSet_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {

                string ConnString;

                SqlConnectionStringBuilder Builder = new
                     SqlConnectionStringBuilder();
                Builder.DataSource = "127.0.0.1";
                Builder.InitialCatalog = "Authority";
                Builder.UserID = "sa";
                Builder.Password = "12345";
                Builder.IntegratedSecurity = true;
                Builder.ConnectTimeout = 30;

                ConnString = Builder.ConnectionString;


                //Step 1：開啟資料庫連接，準備與資料庫進行溝通和存取
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                string selectCmd = "SELECT * FROM Login";

                // Step 2：資料配接器的宣告，來執行SQL敘述並開啟資料庫連接
                SqlDataAdapter da = new SqlDataAdapter(selectCmd, conn);

                // Step 3：宣告DataSet，用DataAdapter將SQL執行結果指定資料表填入DataSet中
                DataSet ds = new DataSet();
                da.Fill(ds, "Login");

                var Login = ds.Tables["Login"].AsEnumerable();

                var loginQuery = from L in Login
                                 where (L.Field<string>("UserID") == txt_UserID.Text &&
                                        L.Field<string>("Pwd") == txt_Password.Text &&
                                        L.Field<bool>("IsValid") == true)
                                 select L;

                string result = "";
                if (loginQuery.Count() == 1)
                {
                    result = "密碼正確![" + txt_UserID.Text + "]您可以進入系統。\n";
                    foreach (var obj in loginQuery)
                    {
                        result = result + "您的身份為[" + obj.Field<string>("Condition") + "]";
                    }
                    MessageBox.Show(result, "登入成功");
                }
                else
                {
                    result = "可能[密碼]或[帳號]有誤或是[帳號無效]，請重新輸入。";
                    MessageBox.Show(result, "登入失敗");
                }

                conn.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "例外資訊");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.txt_UserID.Text = "";
            this.txt_Password.Text = "";
        }
    }
}
