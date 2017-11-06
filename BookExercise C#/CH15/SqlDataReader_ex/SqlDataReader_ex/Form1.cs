﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ADO.NET for SQL Server
namespace SqlDataReader_ex
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
                string msg = "";
                string ConnString;
                ConnString = "Data Source =127.0.01;Initial catalog = Authority;" +
                                 "User id = sa;Password = 12345";

                //Step 1：開啟資料庫連接，準備與資料庫進行溝通和存取
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                string selectCmd = "SELECT * FROM Login WHERE UserID = '" +
                txt_UserID.Text + "' And Pwd ='" + txt_Password.Text +
                "' And IsValid =1";

                //Step 2：透過Connection連接物件來送出SQL敘述
                SqlCommand cmd = new SqlCommand(selectCmd, conn);

                //Step 3：由DataReader讀取SQL敘述的執行結果集
                SqlDataReader dr = cmd.ExecuteReader();

                //Step 4：資料錄讀取
                if (dr.Read())
                {
                    msg = "密碼正確![" + dr["UserID"] + "]您可以進入系統。\n";
                    msg = msg + "您的身份為[" + dr["Condition"] + "]。";
                    MessageBox.Show(msg, "登入成功");
                }
                else
                {
                    msg = "可能[密碼]或[帳號]有誤或是[帳號無效]，請重新輸入。";
                    MessageBox.Show(msg, "登入失敗");
                }

                //Step 5：關閉連接物件與資料讀取器
                conn.Close();
                dr.Close();
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