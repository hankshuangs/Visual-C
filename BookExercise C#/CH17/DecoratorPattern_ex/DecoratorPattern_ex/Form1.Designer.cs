namespace DecoratorPattern_ex
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
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnExpansion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(41, 34);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(133, 60);
            this.btnOriginal.TabIndex = 0;
            this.btnOriginal.Text = "原始功能";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnExpansion
            // 
            this.btnExpansion.Location = new System.Drawing.Point(197, 34);
            this.btnExpansion.Name = "btnExpansion";
            this.btnExpansion.Size = new System.Drawing.Size(128, 60);
            this.btnExpansion.TabIndex = 1;
            this.btnExpansion.Text = "擴充功能";
            this.btnExpansion.UseVisualStyleBackColor = true;
            this.btnExpansion.Click += new System.EventHandler(this.btnExpansion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 126);
            this.Controls.Add(this.btnExpansion);
            this.Controls.Add(this.btnOriginal);
            this.Name = "Form1";
            this.Text = "Decorator Pattern範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnExpansion;
    }
}

