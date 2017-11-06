namespace BoxingUnboxing
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
            this.btnUnboxing = new System.Windows.Forms.Button();
            this.btnBoxing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnboxing
            // 
            this.btnUnboxing.Location = new System.Drawing.Point(98, 135);
            this.btnUnboxing.Name = "btnUnboxing";
            this.btnUnboxing.Size = new System.Drawing.Size(132, 51);
            this.btnUnboxing.TabIndex = 5;
            this.btnUnboxing.Text = "Unboxing";
            this.btnUnboxing.UseVisualStyleBackColor = true;
            this.btnUnboxing.Click += new System.EventHandler(this.btnUnboxing_Click);
            // 
            // btnBoxing
            // 
            this.btnBoxing.Location = new System.Drawing.Point(98, 39);
            this.btnBoxing.Name = "btnBoxing";
            this.btnBoxing.Size = new System.Drawing.Size(132, 53);
            this.btnBoxing.TabIndex = 4;
            this.btnBoxing.Text = "Boxing";
            this.btnBoxing.UseVisualStyleBackColor = true;
            this.btnBoxing.Click += new System.EventHandler(this.btnBoxing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 261);
            this.Controls.Add(this.btnUnboxing);
            this.Controls.Add(this.btnBoxing);
            this.Name = "Form1";
            this.Text = "Boxing & Unboxing範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnboxing;
        private System.Windows.Forms.Button btnBoxing;
    }
}

