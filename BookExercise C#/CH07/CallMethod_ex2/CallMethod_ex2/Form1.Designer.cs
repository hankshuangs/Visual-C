namespace CallMethod_ex2
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
            this.btnStatic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDynamic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(40, 117);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(191, 62);
            this.btnStatic.TabIndex = 8;
            this.btnStatic.Text = "靜態方法的呼叫";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "不同類別的呼叫";
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(40, 51);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(191, 60);
            this.btnDynamic.TabIndex = 6;
            this.btnDynamic.Text = "動態方法的呼叫";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDynamic);
            this.Name = "Form1";
            this.Text = "方法呼叫範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDynamic;
    }
}

