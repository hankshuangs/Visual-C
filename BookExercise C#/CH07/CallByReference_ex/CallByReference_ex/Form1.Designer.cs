namespace CallByReference_ex
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
            this.btnByReference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnByReference
            // 
            this.btnByReference.Location = new System.Drawing.Point(29, 25);
            this.btnByReference.Name = "btnByReference";
            this.btnByReference.Size = new System.Drawing.Size(330, 49);
            this.btnByReference.TabIndex = 2;
            this.btnByReference.Text = "傳參考呼叫";
            this.btnByReference.UseVisualStyleBackColor = true;
            this.btnByReference.Click += new System.EventHandler(this.btnByReference_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 88);
            this.Controls.Add(this.btnByReference);
            this.Name = "Form1";
            this.Text = "傳參考呼叫(call by reference)範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnByReference;
    }
}

