namespace ImplicitExplicitConversion
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
            this.btnExplicit = new System.Windows.Forms.Button();
            this.btnImplicit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExplicit
            // 
            this.btnExplicit.Location = new System.Drawing.Point(95, 96);
            this.btnExplicit.Name = "btnExplicit";
            this.btnExplicit.Size = new System.Drawing.Size(132, 41);
            this.btnExplicit.TabIndex = 5;
            this.btnExplicit.Text = "明確轉換";
            this.btnExplicit.UseVisualStyleBackColor = true;
            this.btnExplicit.Click += new System.EventHandler(this.btnExplicit_Click);
            // 
            // btnImplicit
            // 
            this.btnImplicit.Location = new System.Drawing.Point(95, 34);
            this.btnImplicit.Name = "btnImplicit";
            this.btnImplicit.Size = new System.Drawing.Size(132, 42);
            this.btnImplicit.TabIndex = 4;
            this.btnImplicit.Text = "隱含轉換";
            this.btnImplicit.UseVisualStyleBackColor = true;
            this.btnImplicit.Click += new System.EventHandler(this.btnImplicit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 169);
            this.Controls.Add(this.btnExplicit);
            this.Controls.Add(this.btnImplicit);
            this.Name = "Form1";
            this.Text = "隱含轉換和明確轉換範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExplicit;
        private System.Windows.Forms.Button btnImplicit;
    }
}

