namespace MyResource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAuthorInfo = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuthorInfo
            // 
            this.btnAuthorInfo.Location = new System.Drawing.Point(176, 255);
            this.btnAuthorInfo.Name = "btnAuthorInfo";
            this.btnAuthorInfo.Size = new System.Drawing.Size(111, 38);
            this.btnAuthorInfo.TabIndex = 5;
            this.btnAuthorInfo.Text = "作者資訊";
            this.btnAuthorInfo.UseVisualStyleBackColor = true;
            this.btnAuthorInfo.Click += new System.EventHandler(this.btnAuthorInfo_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(59, 255);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 38);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "改變背景圖片";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(299, 296);
            this.Controls.Add(this.btnAuthorInfo);
            this.Controls.Add(this.btnChange);
            this.Name = "Form1";
            this.Text = "資源檔範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorInfo;
        private System.Windows.Forms.Button btnChange;
    }
}

