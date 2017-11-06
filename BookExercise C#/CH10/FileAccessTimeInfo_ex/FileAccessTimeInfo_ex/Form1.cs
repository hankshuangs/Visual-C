using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //新增此命名空間
namespace FileAccessTimeInfo_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetFileInfo_Click(object sender, EventArgs e)
        {
            string FileName = Application.StartupPath + @"\Java.jpg";
            string msg = "";

            if (File.Exists(FileName))
            {
                msg = msg + "檔案:[" + FileName + "]有找到!\n";

                msg = msg + "建立時間:[" + File.GetCreationTime(FileName) + "]!\n";

                msg = msg + "上次存取時間:[" + File.GetLastAccessTime(FileName) + "]!\n";

                msg = msg + "上次寫入時間:[" + File.GetLastWriteTime(FileName) + "]!\n";

                MessageBox.Show(msg, "File類別靜態方法");
            }
            else
            {
                msg = msg + "檔案:[" + FileName + "]沒有找到!\n";
                msg = msg + "無法提供檔案任何資訊";
                MessageBox.Show(msg, "File類別靜態方法");
            }
        }
    }
}
