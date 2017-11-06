using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            notifyIcon1.Icon = new Icon("DrMaster.ico");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string TipText = "即時病毒偵測開啟中...\n";
            TipText = TipText + "正在掃描檔案與電子郵件...請稍候!";

            notifyIcon1.BalloonTipTitle = "博碩科技超級防毒系統";
            notifyIcon1.BalloonTipText = TipText;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "Welcome to DrMaster!!";
            notifyIcon1.ShowBalloonTip(5000);
            notifyIcon1.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }
    }
}
