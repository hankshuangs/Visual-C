namespace ClassDeclare_ex
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.rdoCar2 = new System.Windows.Forms.RadioButton();
            this.rdoCar1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(38, 134);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(222, 45);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "建立";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rdoCar2
            // 
            this.rdoCar2.AutoSize = true;
            this.rdoCar2.Location = new System.Drawing.Point(38, 93);
            this.rdoCar2.Name = "rdoCar2";
            this.rdoCar2.Size = new System.Drawing.Size(135, 16);
            this.rdoCar2.TabIndex = 10;
            this.rdoCar2.Text = "Mitsubishi Lancer Fortis";
            this.rdoCar2.UseVisualStyleBackColor = true;
            // 
            // rdoCar1
            // 
            this.rdoCar1.AutoSize = true;
            this.rdoCar1.Checked = true;
            this.rdoCar1.Location = new System.Drawing.Point(38, 58);
            this.rdoCar1.Name = "rdoCar1";
            this.rdoCar1.Size = new System.Drawing.Size(107, 16);
            this.rdoCar1.TabIndex = 9;
            this.rdoCar1.TabStop = true;
            this.rdoCar1.Text = "Mitsubishi Eclipse";
            this.rdoCar1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "請您選擇所要建立的三菱汽車:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rdoCar2);
            this.Controls.Add(this.rdoCar1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "類別宣告範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rdoCar2;
        private System.Windows.Forms.RadioButton rdoCar1;
        private System.Windows.Forms.Label label1;
    }
}

