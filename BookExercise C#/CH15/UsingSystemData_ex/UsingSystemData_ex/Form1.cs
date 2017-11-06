using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;     //ADO.NET for 存取Access資料庫
using System.Data.SqlClient; //ADO.NET for 存取SQL Server資料庫
namespace UsingSystemData_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection OleConn = new OleDbConnection();

            //因為有匯入System.Data.SqlClient命名空間，
            //故可以省略前段命名空間宣告
            SqlConnection SqlConn1 = new SqlConnection();

            //若沒有匯入System.Data.SqlClient命名空間，
            //則需帶入完整命名空間宣告
            System.Data.SqlClient.SqlConnection SqlConn2 =
                new System.Data.SqlClient.SqlConnection();
        }
    }
}
