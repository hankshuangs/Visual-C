using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // ADO.NET for Access
namespace OleDbConnectionStringBuilder_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            string selectCmd = "select BULLETIN_ID as 編號 , BULLETIN_UNIT as 部門 ," +
         "BULLETIN_CAPTION as 主旨 , BULLETIN_DATE as 日期 , CONTENTS as 內容 " +
         " from BULLETIN Where BULLETIN_DATE Between '"
             + DTP_From.Value.ToString("yyyy年MM月dd日") + "' And '"
             + DTP_To.Value.ToString("yyyy年MM月dd日") + "' And "
             + "IS_DISPLAY=True And ";


            selectCmd = selectCmd + "CONTENTS Like '%" + txt_keyword.Text +
                                 "%' Order by BULLETIN_DATE DESC";

            string ConnString;

            OleDbConnectionStringBuilder Builder = new
                      OleDbConnectionStringBuilder();
            Builder.Provider = "Microsoft.Jet.OLEDB.4.0";
            Builder.DataSource = Application.StartupPath + "\\Ecram.mdb";
            Builder.Add("Jet OLEDB:Database Password", "12345");

            ConnString = Builder.ConnectionString;

            OleDbConnection Conn = new OleDbConnection(ConnString);
            Conn.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(selectCmd, Conn);
            DataTable DT = new DataTable();
            da.Fill(DT);

            if (DT.Rows.Count == 0)
            {
                MessageBox.Show(this, "搜尋條件並未找到任何符合資料", "搜尋結果");
            }
            else
            {
                MessageBox.Show(this, "共找到資料筆數" + DT.Rows.Count.ToString(), "搜尋結果");
            }

            //替代資料列樣式 
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Ivory;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

            dataGridView1.DataSource = DT;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Contents = this.dataGridView1[4, e.RowIndex].Value.ToString();
            MessageBox.Show(this, Contents, "新聞內容");
        }
    }
}
