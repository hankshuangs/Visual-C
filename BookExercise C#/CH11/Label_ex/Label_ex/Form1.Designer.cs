namespace Label_ex
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
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.labDemo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(478, 32);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(121, 37);
            this.btnForeColor.TabIndex = 3;
            this.btnForeColor.Text = "改變前景顏色";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(308, 32);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(130, 37);
            this.btnBackColor.TabIndex = 2;
            this.btnBackColor.Text = "改變背景顏色";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(150, 32);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(104, 38);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "改變字型";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // labDemo
            // 
            this.labDemo.AutoSize = true;
            this.labDemo.Location = new System.Drawing.Point(27, 18);
            this.labDemo.Name = "labDemo";
            this.labDemo.Size = new System.Drawing.Size(91, 12);
            this.labDemo.TabIndex = 4;
            this.labDemo.Text = "我是Label控制項";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnForeColor);
            this.groupBox1.Controls.Add(this.btnBackColor);
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.btnText);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能執行區";
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(17, 32);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(106, 38);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "設定文字";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 180);
            this.Controls.Add(this.labDemo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "標籤控制項範例程式";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label labDemo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnText;
    }
}

