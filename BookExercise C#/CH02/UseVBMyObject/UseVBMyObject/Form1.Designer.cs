﻿namespace UseVBMyObject
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
            this.btnShowUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowUser
            // 
            this.btnShowUser.Location = new System.Drawing.Point(57, 30);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(161, 66);
            this.btnShowUser.TabIndex = 2;
            this.btnShowUser.Text = "顯示使用者名稱";
            this.btnShowUser.UseVisualStyleBackColor = true;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 120);
            this.Controls.Add(this.btnShowUser);
            this.Name = "Form1";
            this.Text = "使用My物件範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowUser;
    }
}
