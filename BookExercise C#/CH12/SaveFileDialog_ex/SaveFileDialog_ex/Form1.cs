using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFileDialog_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SaveFileDialog sfd = new SaveFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {
            sfd.AddExtension = true;
            sfd.CheckFileExists = false; //若為true則儲存的檔案必須存在
            sfd.Filter = "C#類別|*.cs|純文字檔|*.txt|所有檔案|*.*";
            sfd.FilterIndex = 1;//過濾條件預設為［C#類別］
            sfd.FileName = "FileName.cs";
            sfd.InitialDirectory = @"D:\";
            sfd.OverwritePrompt = true;
            sfd.RestoreDirectory = true;
            sfd.Title = "請您選擇要儲存檔案的路徑和輸入檔名";
            sfd.FileOk += new CancelEventHandler(sfd_FileOk);
        }
        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            string msg = "";
            msg = msg + "您選擇儲存的檔案路徑:\n" + sfd.FileName;
            MessageBox.Show(msg, "SaveFileDialog範例");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = sfd.ShowDialog();
            string msg = "";
            if (dr == DialogResult.OK)
            {
                msg = "您按下[確定]鈕\n";
                msg = msg + "檔案[" + sfd.FileName + "]儲存成功!!";
                MessageBox.Show(msg, "資訊");
            }
        }
 
    }
}
