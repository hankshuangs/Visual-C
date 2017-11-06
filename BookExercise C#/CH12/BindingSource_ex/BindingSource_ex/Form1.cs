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
namespace BindingSource_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        private void btnLoadData_Click(object sender, EventArgs e)
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

                string SelectCmd = "Select * From CommunicationList";

                //Step 2:資料配接器宣告,用來執行SQL敘述並且開啟資料庫連接
                da = new OleDbDataAdapter(SelectCmd, conn);

                //Step 3:用DataAdpater將SQL執行結果填入DataSet元件中
                ds = new DataSet();
                da.Fill(ds, "CommunicationList");
                bs.DataSource = ds.Tables["CommunicationList"];

                //設定 UserID 欄位的資料繫結
                txt_UserID.DataBindings.Add("Text", bs, "UserID", true);

                //設定繫結到　PetName　欄位.
                Binding PetNameToBinding = txt_PetName.DataBindings.Add("Text",
                    bs, "PetName", true);

                //設定繫結若為空值所顯示的值.
                PetNameToBinding.NullValue = "Anonymous";


                //設定影像繫結方式,並設定空值預設值
                pictureBox1.DataBindings.Add("Image", bs,
                    "PhotoImg", true, DataSourceUpdateMode.Never,
                       new Bitmap("Nobody.bmp"));

                //設定繫結到 Status 欄位
                txt_Status.DataBindings.Add("Text", bs, "Status", true);

                //設定繫結到 Charm 欄位
                txt_Charm.DataBindings.Add("Text", bs, "Charm", true);

                //設定繫結到 RegisterDateTime 欄位
                dTP_RegisterDateTime.DataBindings.Add("Text", bs, "RegisterDateTime", true);


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
        //首筆
        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }
        //上一筆
        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }
        //下一筆
        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }
        //尾筆
        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
