using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.AddExtension = true;
            ofd.CheckFileExists = true;
            ofd.Filter = "C#類別|*.cs|VB類別|*.vb|純文字檔|*.txt|所有檔案|*.*";
            ofd.FilterIndex = 4;//過濾條件預設為［所有檔案］
            ofd.FileName = "FileName.txt";
            ofd.InitialDirectory = @"C:\";
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.ShowReadOnly = true;//此屬性為true則過濾條件不會顯示副檔名
            ofd.Title = "請您選取多個檔案";
            ofd.FileOk += new CancelEventHandler(ofd_FileOk);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }
        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = ofd.FileNames;
            string msg = "";
            foreach (var obj in files)
            {
                msg = msg + obj + "\n";
            }
            msg = msg + "是否唯讀開啟檔案:" + ofd.ReadOnlyChecked + "\n";
            msg = msg + "開啟檔案數:" + ofd.FileNames.Length;
            MessageBox.Show(msg, "OpenFileDialog範例");
        }
    }
}
