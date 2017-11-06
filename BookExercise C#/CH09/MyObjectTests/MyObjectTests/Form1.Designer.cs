namespace MyObjectTests
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
            this.btnCopyrights = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopyrights
            // 
            this.btnCopyrights.Location = new System.Drawing.Point(132, 75);
            this.btnCopyrights.Name = "btnCopyrights";
            this.btnCopyrights.Size = new System.Drawing.Size(144, 36);
            this.btnCopyrights.TabIndex = 11;
            this.btnCopyrights.Text = "獲取版權資訊";
            this.btnCopyrights.UseVisualStyleBackColor = true;
            this.btnCopyrights.Click += new System.EventHandler(this.btnCopyrights_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(132, 18);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(144, 40);
            this.btnUser.TabIndex = 10;
            this.btnUser.Text = "獲取使用者名稱";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "擴充My物件功能";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "原My物件功能";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 133);
            this.Controls.Add(this.btnCopyrights);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Object測試範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyrights;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

