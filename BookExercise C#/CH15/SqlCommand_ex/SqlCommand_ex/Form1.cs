using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //新增命名空間
namespace SqlCommand_ex
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
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {

                string ConnString;
                ConnString = "Data Source =127.0.0.1;Initial catalog = Authority;" +
                                 "User id = sa;Password = 12345";
                conn = new SqlConnection(ConnString);
                conn.Open();

                string UpdateCmd = "Update Login Set Pwd='" + txt_NewPwd.Text +
                        "' WHERE UserID = '" + txt_UserID.Text + "' And Pwd ='" +
                        txt_Password.Text + "' And IsValid =1";

                cmd = new SqlCommand(UpdateCmd, conn);
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

                MessageBox.Show(ex.Message, "例外訊息");
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
