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
namespace DataGridView_ex2
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
            dataGridView1.AutoResizeRows();
        }

        private void tSB_A02_Click(object sender, EventArgs e)
        {
            //變更資料列背景顏色
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            //變更奇數資料列的背景顏色
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Orange;
        }

        private void tSB_A03_Click(object sender, EventArgs e)
        {
            //若要格式化日期值
            dataGridView1.Columns["註冊日期"].DefaultCellStyle.Format =
                "yyyy年MM月dd日 HH:mm:ss";

            //若要魅力指數為貨幣顯示
            dataGridView1.Columns["魅力指數"].DefaultCellStyle.Format = "C";
        }

        private void tSB_A04_Click(object sender, EventArgs e)
        {
            //儲存格中的自動換行
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //儲存格的文字對齊
            dataGridView1.Columns["乳名"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;
        }

        private void tSB_A05_Click(object sender, EventArgs e)
        {
            //設定字型大小,前景背景顏色
            dataGridView1.DefaultCellStyle.Font = new Font("標楷體", 15);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.DefaultCellStyle.BackColor = Color.Pink;
            //設定選取前景顏色與背景顏色
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Chocolate;
        }

        private void tSB_A06_Click(object sender, EventArgs e)
        {
            dataGridView1.GridColor = Color.BlueViolet;
        }

        private void tSB_A07_Click(object sender, EventArgs e)
        {
            //儲存格背景顏色和字型設定
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            //特定資料列儲存格背景顏色設定
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightPink;
            dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.LightPink;
            //特定資料行前景顏色和格式化輸出
            dataGridView1.Columns["乳名"].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns["魅力指數"].DefaultCellStyle.Format = "D6";
        }

        private void tSB_A08_Click(object sender, EventArgs e)
        {
            //3D凸起框線
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            //3D下凹框線
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            //單行框線
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }


    }
}
