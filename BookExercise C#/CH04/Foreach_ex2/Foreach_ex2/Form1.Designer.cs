namespace Foreach_ex2
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
            this.Mybutton = new System.Windows.Forms.Button();
            this.ＭytextBox = new System.Windows.Forms.TextBox();
            this.MyradioButton = new System.Windows.Forms.RadioButton();
            this.MycheckBox = new System.Windows.Forms.CheckBox();
            this.MycomboBox = new System.Windows.Forms.ComboBox();
            this.Mylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mybutton
            // 
            this.Mybutton.Location = new System.Drawing.Point(38, 164);
            this.Mybutton.Name = "Mybutton";
            this.Mybutton.Size = new System.Drawing.Size(204, 48);
            this.Mybutton.TabIndex = 17;
            this.Mybutton.Text = "顯示表單內所有控制項";
            this.Mybutton.UseVisualStyleBackColor = true;
            this.Mybutton.Click += new System.EventHandler(this.Mybutton_Click);
            // 
            // ＭytextBox
            // 
            this.ＭytextBox.Location = new System.Drawing.Point(38, 127);
            this.ＭytextBox.Name = "ＭytextBox";
            this.ＭytextBox.Size = new System.Drawing.Size(100, 22);
            this.ＭytextBox.TabIndex = 16;
            // 
            // MyradioButton
            // 
            this.MyradioButton.AutoSize = true;
            this.MyradioButton.Location = new System.Drawing.Point(157, 90);
            this.MyradioButton.Name = "MyradioButton";
            this.MyradioButton.Size = new System.Drawing.Size(85, 16);
            this.MyradioButton.TabIndex = 15;
            this.MyradioButton.TabStop = true;
            this.MyradioButton.Text = "radioButton1";
            this.MyradioButton.UseVisualStyleBackColor = true;
            // 
            // MycheckBox
            // 
            this.MycheckBox.AutoSize = true;
            this.MycheckBox.Location = new System.Drawing.Point(38, 91);
            this.MycheckBox.Name = "MycheckBox";
            this.MycheckBox.Size = new System.Drawing.Size(77, 16);
            this.MycheckBox.TabIndex = 14;
            this.MycheckBox.Text = "checkBox1";
            this.MycheckBox.UseVisualStyleBackColor = true;
            // 
            // MycomboBox
            // 
            this.MycomboBox.FormattingEnabled = true;
            this.MycomboBox.Location = new System.Drawing.Point(38, 53);
            this.MycomboBox.Name = "MycomboBox";
            this.MycomboBox.Size = new System.Drawing.Size(121, 20);
            this.MycomboBox.TabIndex = 13;
            // 
            // Mylabel
            // 
            this.Mylabel.AutoSize = true;
            this.Mylabel.Location = new System.Drawing.Point(36, 23);
            this.Mylabel.Name = "Mylabel";
            this.Mylabel.Size = new System.Drawing.Size(33, 12);
            this.Mylabel.TabIndex = 12;
            this.Mylabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 229);
            this.Controls.Add(this.Mybutton);
            this.Controls.Add(this.ＭytextBox);
            this.Controls.Add(this.MyradioButton);
            this.Controls.Add(this.MycheckBox);
            this.Controls.Add(this.MycomboBox);
            this.Controls.Add(this.Mylabel);
            this.Name = "Form1";
            this.Text = "foreach迴圈取出表單控制項範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mybutton;
        private System.Windows.Forms.TextBox ＭytextBox;
        private System.Windows.Forms.RadioButton MyradioButton;
        private System.Windows.Forms.CheckBox MycheckBox;
        private System.Windows.Forms.ComboBox MycomboBox;
        private System.Windows.Forms.Label Mylabel;
    }
}

