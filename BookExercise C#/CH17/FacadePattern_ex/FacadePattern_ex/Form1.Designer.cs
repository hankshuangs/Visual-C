namespace FacadePattern_ex
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
            this.btnInvoke = new System.Windows.Forms.Button();
            this.btnFacadeInvoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(40, 27);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(121, 45);
            this.btnInvoke.TabIndex = 0;
            this.btnInvoke.Text = "正常調用";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // btnFacadeInvoke
            // 
            this.btnFacadeInvoke.Location = new System.Drawing.Point(199, 27);
            this.btnFacadeInvoke.Name = "btnFacadeInvoke";
            this.btnFacadeInvoke.Size = new System.Drawing.Size(133, 45);
            this.btnFacadeInvoke.TabIndex = 1;
            this.btnFacadeInvoke.Text = "表象調用";
            this.btnFacadeInvoke.UseVisualStyleBackColor = true;
            this.btnFacadeInvoke.Click += new System.EventHandler(this.btnFacadeInvoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 98);
            this.Controls.Add(this.btnFacadeInvoke);
            this.Controls.Add(this.btnInvoke);
            this.Name = "Form1";
            this.Text = "Facade Pattern範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.Button btnFacadeInvoke;
    }
}

