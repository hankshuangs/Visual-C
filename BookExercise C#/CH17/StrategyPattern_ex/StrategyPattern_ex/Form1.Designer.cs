namespace StrategyPattern_ex
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
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnHbase = new System.Windows.Forms.Button();
            this.btnDynamicSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(35, 31);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(104, 45);
            this.btnSQL.TabIndex = 0;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // btnHbase
            // 
            this.btnHbase.Location = new System.Drawing.Point(170, 31);
            this.btnHbase.Name = "btnHbase";
            this.btnHbase.Size = new System.Drawing.Size(105, 45);
            this.btnHbase.TabIndex = 1;
            this.btnHbase.Text = "HBase";
            this.btnHbase.UseVisualStyleBackColor = true;
            this.btnHbase.Click += new System.EventHandler(this.btnHbase_Click);
            // 
            // btnDynamicSetting
            // 
            this.btnDynamicSetting.Location = new System.Drawing.Point(307, 31);
            this.btnDynamicSetting.Name = "btnDynamicSetting";
            this.btnDynamicSetting.Size = new System.Drawing.Size(95, 45);
            this.btnDynamicSetting.TabIndex = 2;
            this.btnDynamicSetting.Text = "動態置換方法";
            this.btnDynamicSetting.UseVisualStyleBackColor = true;
            this.btnDynamicSetting.Click += new System.EventHandler(this.btnDynamicSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 112);
            this.Controls.Add(this.btnDynamicSetting);
            this.Controls.Add(this.btnHbase);
            this.Controls.Add(this.btnSQL);
            this.Name = "Form1";
            this.Text = "Strategy Pattern範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnHbase;
        private System.Windows.Forms.Button btnDynamicSetting;
    }
}

