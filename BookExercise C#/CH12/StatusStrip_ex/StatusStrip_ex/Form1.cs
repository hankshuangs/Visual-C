using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusStrip_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StatusStrip statusStrip1 = new StatusStrip();
        ToolStripProgressBar tSProgressBar1 = new ToolStripProgressBar();
        ToolStripStatusLabel tSStatusLabel1 = new ToolStripStatusLabel();
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            statusStrip1.Items.AddRange(new ToolStripItem[] { tSStatusLabel1, tSProgressBar1 });
            statusStrip1.Dock = DockStyle.Bottom;
            this.Controls.Add(statusStrip1);

            tSStatusLabel1.Text = "狀態列資訊顯示區";
            tSProgressBar1.Style = ProgressBarStyle.Continuous;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 100)
            {
                count = count + 1;
                string msg = "硬碟重整完成[" + count + "%]";
                tSStatusLabel1.Text = msg;
                tSProgressBar1.Value = count;
            }
            else
            {
                timer1.Enabled = false;
                count = 0;
                MessageBox.Show("硬碟重整完成[100%]", "StatusStrip範例");
                tSStatusLabel1.Text = "狀態列資訊顯示區";
                tSProgressBar1.Value = count;

            }
        }

       
    }
}
