namespace Process_ex
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
            this.tSB_IE = new System.Windows.Forms.ToolStripButton();
            this.tSB_Notepad = new System.Windows.Forms.ToolStripButton();
            this.tSB_RAR = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_IE,
            this.tSB_Notepad,
            this.tSB_RAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 36);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB_IE
            // 
            this.tSB_IE.Image = global::Process_ex.Properties.Resources.IE;
            this.tSB_IE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_IE.Name = "tSB_IE";
            this.tSB_IE.Size = new System.Drawing.Size(189, 33);
            this.tSB_IE.Text = "開啟IE瀏覽器連接指定網址";
            this.tSB_IE.Click += new System.EventHandler(this.tSB_IE_Click);
            // 
            // tSB_Notepad
            // 
            this.tSB_Notepad.Image = global::Process_ex.Properties.Resources.Notepad;
            this.tSB_Notepad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Notepad.Name = "tSB_Notepad";
            this.tSB_Notepad.Size = new System.Drawing.Size(179, 33);
            this.tSB_Notepad.Text = "執行記事本開啟指定檔案";
            this.tSB_Notepad.Click += new System.EventHandler(this.tSB_Notepad_Click);
            // 
            // tSB_RAR
            // 
            this.tSB_RAR.Image = global::Process_ex.Properties.Resources.RAR;
            this.tSB_RAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_RAR.Name = "tSB_RAR";
            this.tSB_RAR.Size = new System.Drawing.Size(107, 33);
            this.tSB_RAR.Text = "開啟壓縮檔";
            this.tSB_RAR.Click += new System.EventHandler(this.tSB_RAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 37);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Process元件範例程式";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tSB_Notepad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_IE;
        private System.Windows.Forms.ToolStripButton tSB_RAR;
    }
}

