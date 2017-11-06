namespace SwitchCase_ex1
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
            this.btnGetColor = new System.Windows.Forms.Button();
            this.txtKNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetColor
            // 
            this.btnGetColor.Location = new System.Drawing.Point(90, 107);
            this.btnGetColor.Name = "btnGetColor";
            this.btnGetColor.Size = new System.Drawing.Size(100, 31);
            this.btnGetColor.TabIndex = 8;
            this.btnGetColor.Text = "顯示色彩";
            this.btnGetColor.UseVisualStyleBackColor = true;
            this.btnGetColor.Click += new System.EventHandler(this.btnGetColor_Click);
            // 
            // txtKNum
            // 
            this.txtKNum.Location = new System.Drawing.Point(90, 64);
            this.txtKNum.Name = "txtKNum";
            this.txtKNum.Size = new System.Drawing.Size(100, 22);
            this.txtKNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "請您輸入HID大燈K數?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 157);
            this.Controls.Add(this.btnGetColor);
            this.Controls.Add(this.txtKNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "選擇結構switch陳述句範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetColor;
        private System.Windows.Forms.TextBox txtKNum;
        private System.Windows.Forms.Label label1;
    }
}

