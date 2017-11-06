namespace MessageBox_ex2
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
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.btn_Rewrite = new System.Windows.Forms.Button();
            this.cboIcons = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboButtons = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(211, 200);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(44, 44);
            this.picbox1.TabIndex = 43;
            this.picbox1.TabStop = false;
            // 
            // btn_Rewrite
            // 
            this.btn_Rewrite.Location = new System.Drawing.Point(123, 258);
            this.btn_Rewrite.Name = "btn_Rewrite";
            this.btn_Rewrite.Size = new System.Drawing.Size(75, 33);
            this.btn_Rewrite.TabIndex = 42;
            this.btn_Rewrite.Text = "重寫";
            this.btn_Rewrite.UseVisualStyleBackColor = true;
            this.btn_Rewrite.Click += new System.EventHandler(this.btn_Rewrite_Click);
            // 
            // cboIcons
            // 
            this.cboIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIcons.FormattingEnabled = true;
            this.cboIcons.Items.AddRange(new object[] {
            "Information",
            "Error",
            "Stop",
            "Warning",
            "Question",
            "Exclamation",
            "Asterisk",
            "Hand",
            "None"});
            this.cboIcons.Location = new System.Drawing.Point(26, 224);
            this.cboIcons.Name = "cboIcons";
            this.cboIcons.Size = new System.Drawing.Size(163, 20);
            this.cboIcons.TabIndex = 41;
            this.cboIcons.SelectedIndexChanged += new System.EventHandler(this.cboIcons_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "請您選擇圖示樣式";
            // 
            // cboButtons
            // 
            this.cboButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButtons.FormattingEnabled = true;
            this.cboButtons.Items.AddRange(new object[] {
            "[確定]",
            "[確定][取消]",
            "[是][否]",
            "[是][否][取消]",
            "[重試][取消]",
            "[中止][重試][略過]"});
            this.cboButtons.Location = new System.Drawing.Point(26, 158);
            this.cboButtons.Name = "cboButtons";
            this.cboButtons.Size = new System.Drawing.Size(163, 20);
            this.cboButtons.TabIndex = 39;
            this.cboButtons.SelectedIndexChanged += new System.EventHandler(this.cboButtons_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "請您選擇按鈕樣式";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(24, 258);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 33);
            this.btn_Run.TabIndex = 37;
            this.btn_Run.Text = "執行";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(24, 94);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(100, 22);
            this.txtCaption.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "請您輸入所要顯示的標題";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(24, 39);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(255, 22);
            this.txtText.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "請您輸入所要顯示的文字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.btn_Rewrite);
            this.Controls.Add(this.cboIcons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboButtons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "訊息方塊範例程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Button btn_Rewrite;
        private System.Windows.Forms.ComboBox cboIcons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboButtons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
    }
}

