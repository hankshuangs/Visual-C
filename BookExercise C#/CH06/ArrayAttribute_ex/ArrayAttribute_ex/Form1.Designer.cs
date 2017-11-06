namespace ArrayAttribute_ex
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
            this.btnRank = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(32, 111);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(221, 70);
            this.btnRank.TabIndex = 5;
            this.btnRank.Text = "Rank－取得陣列維度";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(31, 28);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(222, 62);
            this.btnLength.TabIndex = 4;
            this.btnLength.Text = "Length－取得陣列元素總數";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnLength);
            this.Name = "Form1";
            this.Text = "陣列屬性範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnLength;
    }
}

