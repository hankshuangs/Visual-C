﻿namespace DirectoryGetDirectories_ex
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
            this.rtxtListDirs = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListDirs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtListDirs
            // 
            this.rtxtListDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtListDirs.Location = new System.Drawing.Point(3, 18);
            this.rtxtListDirs.Name = "rtxtListDirs";
            this.rtxtListDirs.Size = new System.Drawing.Size(286, 168);
            this.rtxtListDirs.TabIndex = 0;
            this.rtxtListDirs.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtListDirs);
            this.groupBox1.Location = new System.Drawing.Point(34, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目錄子目錄清單";
            // 
            // btnListDirs
            // 
            this.btnListDirs.Location = new System.Drawing.Point(37, 15);
            this.btnListDirs.Name = "btnListDirs";
            this.btnListDirs.Size = new System.Drawing.Size(286, 35);
            this.btnListDirs.TabIndex = 4;
            this.btnListDirs.Text = "列出目錄中所有子目錄";
            this.btnListDirs.UseVisualStyleBackColor = true;
            this.btnListDirs.Click += new System.EventHandler(this.btnListDirs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListDirs);
            this.Name = "Form1";
            this.Text = "列出目錄中所有子目錄範例程式";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtListDirs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListDirs;
    }
}

