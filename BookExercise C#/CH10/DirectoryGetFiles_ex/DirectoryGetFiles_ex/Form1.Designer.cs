namespace DirectoryGetFiles_ex
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
            this.btnListFiles = new System.Windows.Forms.Button();
            this.rtxtListFiles = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListFiles
            // 
            this.btnListFiles.Location = new System.Drawing.Point(22, 12);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(354, 47);
            this.btnListFiles.TabIndex = 4;
            this.btnListFiles.Text = "列出目錄所有檔案";
            this.btnListFiles.UseVisualStyleBackColor = true;
            this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
            // 
            // rtxtListFiles
            // 
            this.rtxtListFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtListFiles.Location = new System.Drawing.Point(3, 18);
            this.rtxtListFiles.Name = "rtxtListFiles";
            this.rtxtListFiles.Size = new System.Drawing.Size(348, 149);
            this.rtxtListFiles.TabIndex = 0;
            this.rtxtListFiles.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtListFiles);
            this.groupBox1.Location = new System.Drawing.Point(22, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目錄檔案清單";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 259);
            this.Controls.Add(this.btnListFiles);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "列出目錄所有檔案範例程式";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListFiles;
        private System.Windows.Forms.RichTextBox rtxtListFiles;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

