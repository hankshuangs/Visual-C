using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //新增命名空間 for ACCESS
namespace OleDbCommand_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //變更密碼
        private void btn_OK_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = null;
            OleDbCommand cmd = null;
            try
            {

                string ConnString;
                ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                      Application.StartupPath + "\\Authority.mdb;" +
                      "Jet OLEDB:Database Password=12345";

                conn = new OleDbConnection(ConnString);
                conn.Open();



                string UpdateCmd = "Update Login Set Pwd='" + txt_NewPwd.Text +
                        "' WHERE UserID = '" + txt_UserID.Text + "' And Pwd ='" +
                        txt_Password.Text + "' And IsValid =true";
                //注意:SQL Server應為IsValid = 1;
                //注意:Access資料庫欄位名稱不可為Password

                cmd = new OleDbCommand(UpdateCmd, conn);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("恭喜您，密碼變更成功!", "密碼變更");
                }
                else
                {
                    MessageBox.Show("對不起，密碼變更失敗!", "密碼變更");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }
        //關閉表單
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
