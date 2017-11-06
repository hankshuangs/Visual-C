namespace Method_ex
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
            this.btnCreateMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateMethod
            // 
            this.btnCreateMethod.Location = new System.Drawing.Point(40, 32);
            this.btnCreateMethod.Name = "btnCreateMethod";
            this.btnCreateMethod.Size = new System.Drawing.Size(193, 69);
            this.btnCreateMethod.TabIndex = 2;
            this.btnCreateMethod.Text = "建立方法";
            this.btnCreateMethod.UseVisualStyleBackColor = true;
            this.btnCreateMethod.Click += new System.EventHandler(this.btnCreateMethod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btnCreateMethod);
            this.Name = "Form1";
            this.Text = "建立方法範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMethod;
    }
}

