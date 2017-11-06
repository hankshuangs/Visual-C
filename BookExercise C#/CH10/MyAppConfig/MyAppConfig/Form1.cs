using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //新增命名空間
namespace MyAppConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //讀取連線字串
        private void button1_Click(object sender, EventArgs e)
        {
            // 獲取應用組態檔案.
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            // 獲取連接字串區段.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;

            string msg = "";
            for (int i = 1; i < ConfigurationManager.ConnectionStrings.Count; i++)
            {
                ConnectionStringSettings cs =
                    csSection.ConnectionStrings[i];

                msg = msg + "第[" + i.ToString() + "]" + "\r\n";
                msg = msg + "連線字串:" + cs.ConnectionString + "\r\n";
                msg = msg + "名稱:" + cs.Name + "\r\n";
                msg = msg + "資料提供者名稱:" + cs.ProviderName + "\r\n";
                msg = msg + "-----------------------------------" + "\r\n";
            }
            MessageBox.Show(msg, "擷取所有連接字串");
        }
        //讀取應用程式設定區段
        private void button2_Click(object sender, EventArgs e)
        {
            AppSettingsReader ASReader = new AppSettingsReader();
            object objtmp1, objtmp2;
            objtmp1 = ASReader.GetValue("adminName", typeof(string));
            objtmp2 = ASReader.GetValue("password", typeof(string));
            string msg = "";

            msg = "姓名：" + objtmp1.ToString() + "\n";
            msg = msg + "密碼：" + objtmp2.ToString() + "\n";
            MessageBox.Show(msg, "讀取應用程式設定區段");
        }
        //讀取Access連線字串
        private void button3_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings settings =
              ConfigurationManager.ConnectionStrings["AccessConnectionString"];
            MessageBox.Show(this, settings.ConnectionString, "Access連線字串");
        }
        //讀取SQL Server連線字串
            private void button4_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings settings =
             ConfigurationManager.ConnectionStrings["SQLServerConnectionString"];
            MessageBox.Show(this, settings.ConnectionString, "SQL Server連線字串");
        }
        
    }
}
