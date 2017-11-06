namespace MySettings
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
            this.btnConnectionString = new System.Windows.Forms.Button();
            this.btnCopyrights = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectionString
            // 
            this.btnConnectionString.Location = new System.Drawing.Point(87, 332);
            this.btnConnectionString.Name = "btnConnectionString";
            this.btnConnectionString.Size = new System.Drawing.Size(143, 32);
            this.btnConnectionString.TabIndex = 5;
            this.btnConnectionString.Text = "顯示SQL 連線字串";
            this.btnConnectionString.UseVisualStyleBackColor = true;
            this.btnConnectionString.Click += new System.EventHandler(this.btnConnectionString_Click);
            // 
            // btnCopyrights
            // 
            this.btnCopyrights.Location = new System.Drawing.Point(2, 3);
            this.btnCopyrights.Name = "btnCopyrights";
            this.btnCopyrights.Size = new System.Drawing.Size(96, 33);
            this.btnCopyrights.TabIndex = 4;
            this.btnCopyrights.Text = "顯示版權";
            this.btnCopyrights.UseVisualStyleBackColor = true;
            this.btnCopyrights.Click += new System.EventHandler(this.btnCopyrights_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySettings.Properties.Resources.M1800;
            this.ClientSize = new System.Drawing.Size(231, 365);
            this.Controls.Add(this.btnConnectionString);
            this.Controls.Add(this.btnCopyrights);
            this.Name = "Form1";
            this.Text = "設定檔範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionString;
        private System.Windows.Forms.Button btnCopyrights;
    }
}

