﻿namespace CallMethod_ex1
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
            this.btnCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(50, 21);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(170, 43);
            this.btnCall.TabIndex = 2;
            this.btnCall.Text = "同一類別內的呼叫";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 85);
            this.Controls.Add(this.btnCall);
            this.Name = "Form1";
            this.Text = "方法呼叫範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
    }
}

