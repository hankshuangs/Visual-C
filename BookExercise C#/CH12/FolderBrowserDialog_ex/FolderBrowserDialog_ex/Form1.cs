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
namespace FolderBrowserDialog_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        string[] files;
        int index;
        long fileCounts;
        long totalfiles;
        float ScanPercent;
        private void Form1_Load(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = @"C:\";
            fbd.ShowNewFolderButton = true;

            btnScan.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            txtFolderPath.Text = fbd.SelectedPath;
            if (txtFolderPath.Text != "")
            {
                btnScan.Enabled = true;
            }
        }


        private void btnScan_Click(object sender, EventArgs e)
        {
            index = 0;
            fileCounts = 0;
            totalfiles = 0;
            ScanPercent = 0;
            files = null;
            files = Directory.GetFiles(txtFolderPath.Text, "*", SearchOption.AllDirectories);
            totalfiles = files.Length;
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStop.Text = "啟動";
            }
            else
            {
                timer1.Enabled = true;
                btnStop.Text = "停止";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFilePath.Text = files[index];
            fileCounts = index + 1;
            ScanPercent = (fileCounts * 100) / totalfiles;

            if (index == (files.Length - 1))
            {
                lblFileCount.Text = fileCounts.ToString();
                sSSlblPercent.Text = string.Format("{0:F0}%", ScanPercent);
                timer1.Enabled = false;
                string msg = "檢測檔案數:" + lblFileCount.Text + "\n";
                msg = msg + "檢測結果無任何檔案中毒^_^";
                MessageBox.Show(msg, "掃毒進度100%");


            }
            else
            {
                index = index + 1;
                lblFileCount.Text = fileCounts.ToString();
                sSSlblPercent.Text = string.Format("{0:F0}%", ScanPercent);
            }
        }

        
       
    }
}
