namespace Delegate_ex
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
            this.btnOpenTV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenTV
            // 
            this.btnOpenTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenTV.Location = new System.Drawing.Point(0, 0);
            this.btnOpenTV.Name = "btnOpenTV";
            this.btnOpenTV.Size = new System.Drawing.Size(335, 137);
            this.btnOpenTV.TabIndex = 2;
            this.btnOpenTV.Text = "開啟電視";
            this.btnOpenTV.UseVisualStyleBackColor = true;
            this.btnOpenTV.Click += new System.EventHandler(this.btnOpenTV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 137);
            this.Controls.Add(this.btnOpenTV);
            this.Name = "Form1";
            this.Text = "簡單的委派範例程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTV;
    }
}

