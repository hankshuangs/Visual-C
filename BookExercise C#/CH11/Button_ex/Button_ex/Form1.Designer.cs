namespace Button_ex
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
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnIsEnabled = new System.Windows.Forms.Button();
            this.btnFlatStyle = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(113, 17);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(73, 50);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            // 
            // btnIsEnabled
            // 
            this.btnIsEnabled.Location = new System.Drawing.Point(134, 81);
            this.btnIsEnabled.Name = "btnIsEnabled";
            this.btnIsEnabled.Size = new System.Drawing.Size(105, 39);
            this.btnIsEnabled.TabIndex = 3;
            this.btnIsEnabled.Text = "按鈕啟動/關閉";
            this.btnIsEnabled.UseVisualStyleBackColor = true;
            this.btnIsEnabled.Click += new System.EventHandler(this.btnIsEnabled_Click);
            // 
            // btnFlatStyle
            // 
            this.btnFlatStyle.Location = new System.Drawing.Point(20, 81);
            this.btnFlatStyle.Name = "btnFlatStyle";
            this.btnFlatStyle.Size = new System.Drawing.Size(97, 39);
            this.btnFlatStyle.TabIndex = 2;
            this.btnFlatStyle.Text = "改變按鈕外觀";
            this.btnFlatStyle.UseVisualStyleBackColor = true;
            this.btnFlatStyle.Click += new System.EventHandler(this.btnFlatStyle_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(134, 22);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(105, 41);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "改變按鈕圖示";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIsEnabled);
            this.groupBox1.Controls.Add(this.btnFlatStyle);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.btnText);
            this.groupBox1.Location = new System.Drawing.Point(18, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能區";
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(20, 22);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(97, 41);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "改變按鈕文字";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "按鈕控制項範例程式";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnIsEnabled;
        private System.Windows.Forms.Button btnFlatStyle;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnText;
    }
}

