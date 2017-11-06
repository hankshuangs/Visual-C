using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  //新增
namespace DataGridView_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
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
                Builder.DataSource = Application.StartupPath + @"\communication.mdb";
                Builder.Add("Jet OLEDB:Database Password", "12345");

                //Step 1: 開啟資料庫連接
                conn = new OleDbConnection(Builder.ConnectionString);
                conn.Open();

                string SelectCmd = "Select UserID as 使用者編號 , PetName as 乳名 ," +
                    " PhotoImg as 照片 , Status as 狀態 , Charm as 魅力指數 , " +
                    "RegisterDateTime as 註冊日期 From CommunicationList";

                //Step 2:資料配接器宣告,用來執行SQL敘述並且開啟資料庫連接
                da = new OleDbDataAdapter(SelectCmd, conn);

                //Step 3:用DataAdpater將SQL執行結果填入DataSet元件中
                ds = new DataSet();
                da.Fill(ds, "CommunicationList");

                dataGridView1.DataSource = ds.Tables["CommunicationList"];

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

        private void tSB_A01_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "使用者編號(UserID)";
            dataGridView1.Columns[1].HeaderText = "乳名(PetName)";
            dataGridView1.Columns[2].HeaderText = "照片(PhotoImg)";
            dataGridView1.Columns[3].HeaderText = "狀態(Status)";
            dataGridView1.Columns[4].HeaderText = "魅力指數(Charm)";
            dataGridView1.Columns[5].HeaderText = "註冊日期(RegisterDateTime)";
        }

        private void tSB_A02_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["使用者編號"].Visible = false;
            dataGridView1.Columns["註冊日期"].Visible = false;
        }

        private void tSB_A03_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = false;
        }

        private void tSB_A04_Click(object sender, EventArgs e)
        {
            //凍結欄位當捲動水平軸時,乳名欄位會固定不會跟著捲動
            dataGridView1.Columns["乳名"].Frozen = true;
            //使[使用者編號]欄位成為唯讀,於該欄位中的儲存格均無法Click
            dataGridView1.Columns["使用者編號"].ReadOnly = true;
        }

        private void tSB_A05_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToOrderColumns = true;
        }

        private void tSB_A06_Click(object sender, EventArgs e)
        {
            //防止在DataGridView中新增資料列和刪除資料列
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void tSB_A07_Click(object sender, EventArgs e)
        {
            //設定目前儲存格位於 行 1, 列 3. 
            dataGridView1.CurrentCell = dataGridView1[1, 3];

            string msg = string.Format("列: [{0}], 行: [{1}] , 內容值: [{2}]",
            dataGridView1.CurrentCell.RowIndex,
            dataGridView1.CurrentCell.ColumnIndex,
            dataGridView1.CurrentCell.Value);
            MessageBox.Show(this, msg, "目前儲存格資訊");
        }

        private void tSB_A08_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["照片"].Width = 100;
            dataGridView1.Columns[1].Width = 80;

            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Rows[3].Height = 120;
        }
    }
}
