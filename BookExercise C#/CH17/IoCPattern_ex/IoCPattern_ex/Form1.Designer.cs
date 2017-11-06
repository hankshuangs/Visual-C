namespace IoCPattern_ex
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
            this.btnAppconfig = new System.Windows.Forms.Button();
            this.btnSQLServer = new System.Windows.Forms.Button();
            this.btnOracle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppconfig
            // 
            this.btnAppconfig.Location = new System.Drawing.Point(46, 148);
            this.btnAppconfig.Name = "btnAppconfig";
            this.btnAppconfig.Size = new System.Drawing.Size(340, 46);
            this.btnAppconfig.TabIndex = 0;
            this.btnAppconfig.Text = "Run From App.config";
            this.btnAppconfig.UseVisualStyleBackColor = true;
            this.btnAppconfig.Click += new System.EventHandler(this.btnAppconfig_Click);
            // 
            // btnSQLServer
            // 
            this.btnSQLServer.Location = new System.Drawing.Point(46, 211);
            this.btnSQLServer.Name = "btnSQLServer";
            this.btnSQLServer.Size = new System.Drawing.Size(159, 47);
            this.btnSQLServer.TabIndex = 1;
            this.btnSQLServer.Text = "SQL Server";
            this.btnSQLServer.UseVisualStyleBackColor = true;
            this.btnSQLServer.Click += new System.EventHandler(this.btnSQLServer_Click);
            // 
            // btnOracle
            // 
            this.btnOracle.Location = new System.Drawing.Point(230, 211);
            this.btnOracle.Name = "btnOracle";
            this.btnOracle.Size = new System.Drawing.Size(156, 49);
            this.btnOracle.TabIndex = 2;
            this.btnOracle.Text = "Oracle";
            this.btnOracle.UseVisualStyleBackColor = true;
            this.btnOracle.Click += new System.EventHandler(this.btnOracle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IoCPattern_ex.Properties.Resources.MKTP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 272);
            this.Controls.Add(this.btnOracle);
            this.Controls.Add(this.btnSQLServer);
            this.Controls.Add(this.btnAppconfig);
            this.Name = "Form1";
            this.Text = "IoC Pattern範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppconfig;
        private System.Windows.Forms.Button btnSQLServer;
        private System.Windows.Forms.Button btnOracle;
    }
}

