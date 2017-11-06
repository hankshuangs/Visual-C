namespace CustomException_ex
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLitre = new System.Windows.Forms.TextBox();
            this.cboFuelType = new System.Windows.Forms.ComboBox();
            this.cboCarName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(42, 149);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 39);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "開始加油";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(162, 113);
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(100, 22);
            this.txtLitre.TabIndex = 19;
            // 
            // cboFuelType
            // 
            this.cboFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelType.FormattingEnabled = true;
            this.cboFuelType.Items.AddRange(new object[] {
            "無鉛汽油",
            "柴油"});
            this.cboFuelType.Location = new System.Drawing.Point(141, 73);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(121, 20);
            this.cboFuelType.TabIndex = 18;
            // 
            // cboCarName
            // 
            this.cboCarName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarName.FormattingEnabled = true;
            this.cboCarName.Items.AddRange(new object[] {
            "Eclipse",
            "Tucson"});
            this.cboCarName.Location = new System.Drawing.Point(141, 32);
            this.cboCarName.Name = "cboCarName";
            this.cboCarName.Size = new System.Drawing.Size(121, 20);
            this.cboCarName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "3.輸入加入多少公升?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "2.選擇燃料種類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "1.選擇汽車:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 207);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLitre);
            this.Controls.Add(this.cboFuelType);
            this.Controls.Add(this.cboCarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "客製化例外類別範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLitre;
        private System.Windows.Forms.ComboBox cboFuelType;
        private System.Windows.Forms.ComboBox cboCarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

