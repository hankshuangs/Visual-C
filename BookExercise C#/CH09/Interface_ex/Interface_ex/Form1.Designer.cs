namespace Interface_ex
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.rdoCar2 = new System.Windows.Forms.RadioButton();
            this.rdoCar1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(158, 65);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 54);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查看汽車資訊";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // rdoCar2
            // 
            this.rdoCar2.AutoSize = true;
            this.rdoCar2.Location = new System.Drawing.Point(21, 103);
            this.rdoCar2.Name = "rdoCar2";
            this.rdoCar2.Size = new System.Drawing.Size(88, 16);
            this.rdoCar2.TabIndex = 10;
            this.rdoCar2.TabStop = true;
            this.rdoCar2.Text = "(2) 敞篷跑車";
            this.rdoCar2.UseVisualStyleBackColor = true;
            // 
            // rdoCar1
            // 
            this.rdoCar1.AutoSize = true;
            this.rdoCar1.Checked = true;
            this.rdoCar1.Location = new System.Drawing.Point(21, 65);
            this.rdoCar1.Name = "rdoCar1";
            this.rdoCar1.Size = new System.Drawing.Size(88, 16);
            this.rdoCar1.TabIndex = 9;
            this.rdoCar1.TabStop = true;
            this.rdoCar1.Text = "(1) 雙門跑車";
            this.rdoCar1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "請您選擇要購買的車型?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.rdoCar2);
            this.Controls.Add(this.rdoCar1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "介面與實作範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RadioButton rdoCar2;
        private System.Windows.Forms.RadioButton rdoCar1;
        private System.Windows.Forms.Label label1;
    }
}

