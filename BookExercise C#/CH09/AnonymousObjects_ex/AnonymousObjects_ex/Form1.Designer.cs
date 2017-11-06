namespace AnonymousObjects_ex
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNoReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(39, 90);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 52);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "有回傳值匿名物件方法";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNoReturn
            // 
            this.btnNoReturn.Location = new System.Drawing.Point(39, 22);
            this.btnNoReturn.Name = "btnNoReturn";
            this.btnNoReturn.Size = new System.Drawing.Size(202, 49);
            this.btnNoReturn.TabIndex = 4;
            this.btnNoReturn.Text = "無回傳值匿名物件方法";
            this.btnNoReturn.UseVisualStyleBackColor = true;
            this.btnNoReturn.Click += new System.EventHandler(this.btnNoReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNoReturn);
            this.Name = "Form1";
            this.Text = "匿名物件宣告範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNoReturn;
    }
}

