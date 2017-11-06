namespace ToolStrip_ex
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tSSL_NowStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tSTB_URL = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSB_GoBack = new System.Windows.Forms.ToolStripButton();
            this.tSB_GoForward = new System.Windows.Forms.ToolStripButton();
            this.tSB_Stop = new System.Windows.Forms.ToolStripButton();
            this.tSB_Refresh = new System.Windows.Forms.ToolStripButton();
            this.tSB_GoHome = new System.Windows.Forms.ToolStripButton();
            this.tSB_GoSearch = new System.Windows.Forms.ToolStripButton();
            this.tSB_Go = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_GoBack,
            this.tSB_GoForward,
            this.tSB_Stop,
            this.tSB_Refresh,
            this.tSB_GoHome,
            this.tSB_GoSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 32);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 32);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(560, 259);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // tSSL_NowStatus
            // 
            this.tSSL_NowStatus.ForeColor = System.Drawing.Color.Blue;
            this.tSSL_NowStatus.Name = "tSSL_NowStatus";
            this.tSSL_NowStatus.Size = new System.Drawing.Size(55, 17);
            this.tSSL_NowStatus.Text = "目前狀態";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tSTB_URL,
            this.tSB_Go});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(560, 32);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 29);
            this.toolStripLabel1.Text = "網址:";
            // 
            // tSTB_URL
            // 
            this.tSTB_URL.Name = "tSTB_URL";
            this.tSTB_URL.Size = new System.Drawing.Size(300, 32);
            this.tSTB_URL.Text = "http://chingjunghsu.pixnet.net/blog";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_NowStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSB_GoBack
            // 
            this.tSB_GoBack.Image = global::ToolStrip_ex.Properties.Resources.Left;
            this.tSB_GoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSB_GoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_GoBack.Name = "tSB_GoBack";
            this.tSB_GoBack.Size = new System.Drawing.Size(79, 29);
            this.tSB_GoBack.Text = "上一頁";
            this.tSB_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSB_GoBack.Click += new System.EventHandler(this.tSB_GoBack_Click);
            // 
            // tSB_GoForward
            // 
            this.tSB_GoForward.Image = global::ToolStrip_ex.Properties.Resources.Right;
            this.tSB_GoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_GoForward.Name = "tSB_GoForward";
            this.tSB_GoForward.Size = new System.Drawing.Size(79, 29);
            this.tSB_GoForward.Text = "下一頁";
            this.tSB_GoForward.Click += new System.EventHandler(this.tSB_GoForward_Click);
            // 
            // tSB_Stop
            // 
            this.tSB_Stop.Image = global::ToolStrip_ex.Properties.Resources.Stop;
            this.tSB_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Stop.Name = "tSB_Stop";
            this.tSB_Stop.Size = new System.Drawing.Size(67, 29);
            this.tSB_Stop.Text = "停止";
            this.tSB_Stop.Click += new System.EventHandler(this.tSB_Stop_Click);
            // 
            // tSB_Refresh
            // 
            this.tSB_Refresh.Image = global::ToolStrip_ex.Properties.Resources.Refresh;
            this.tSB_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Refresh.Name = "tSB_Refresh";
            this.tSB_Refresh.Size = new System.Drawing.Size(91, 29);
            this.tSB_Refresh.Text = "重新整理";
            this.tSB_Refresh.Click += new System.EventHandler(this.tSB_Refresh_Click);
            // 
            // tSB_GoHome
            // 
            this.tSB_GoHome.Image = global::ToolStrip_ex.Properties.Resources.Home;
            this.tSB_GoHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_GoHome.Name = "tSB_GoHome";
            this.tSB_GoHome.Size = new System.Drawing.Size(67, 29);
            this.tSB_GoHome.Text = "首頁";
            this.tSB_GoHome.Click += new System.EventHandler(this.tSB_GoHome_Click);
            // 
            // tSB_GoSearch
            // 
            this.tSB_GoSearch.Image = global::ToolStrip_ex.Properties.Resources.Search;
            this.tSB_GoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_GoSearch.Name = "tSB_GoSearch";
            this.tSB_GoSearch.Size = new System.Drawing.Size(67, 29);
            this.tSB_GoSearch.Text = "搜尋";
            this.tSB_GoSearch.Click += new System.EventHandler(this.tSB_GoSearch_Click);
            // 
            // tSB_Go
            // 
            this.tSB_Go.Image = global::ToolStrip_ex.Properties.Resources.Go;
            this.tSB_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Go.Name = "tSB_Go";
            this.tSB_Go.Size = new System.Drawing.Size(67, 29);
            this.tSB_Go.Text = "移至";
            this.tSB_Go.Click += new System.EventHandler(this.tSB_Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 313);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "ToolStrip控制項範例程式";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_GoBack;
        private System.Windows.Forms.ToolStripButton tSB_GoForward;
        private System.Windows.Forms.ToolStripButton tSB_Stop;
        private System.Windows.Forms.ToolStripButton tSB_Refresh;
        private System.Windows.Forms.ToolStripButton tSB_GoHome;
        private System.Windows.Forms.ToolStripButton tSB_GoSearch;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_NowStatus;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tSTB_URL;
        private System.Windows.Forms.ToolStripButton tSB_Go;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

