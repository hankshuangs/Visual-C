namespace MulticastDelegates_ex
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
            this.btnTaipei = new System.Windows.Forms.Button();
            this.btnTaichung = new System.Windows.Forms.Button();
            this.btnKaoHsiung = new System.Windows.Forms.Button();
            this.btnNotify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaipei
            // 
            this.btnTaipei.Location = new System.Drawing.Point(248, 116);
            this.btnTaipei.Name = "btnTaipei";
            this.btnTaipei.Size = new System.Drawing.Size(104, 46);
            this.btnTaipei.TabIndex = 11;
            this.btnTaipei.Text = "台北市-衛生局 ";
            this.btnTaipei.UseVisualStyleBackColor = true;
            this.btnTaipei.Click += new System.EventHandler(this.btnTaipei_Click);
            // 
            // btnTaichung
            // 
            this.btnTaichung.Location = new System.Drawing.Point(136, 116);
            this.btnTaichung.Name = "btnTaichung";
            this.btnTaichung.Size = new System.Drawing.Size(96, 46);
            this.btnTaichung.TabIndex = 10;
            this.btnTaichung.Text = "台中市-衛生局";
            this.btnTaichung.UseVisualStyleBackColor = true;
            this.btnTaichung.Click += new System.EventHandler(this.btnTaichung_Click);
            // 
            // btnKaoHsiung
            // 
            this.btnKaoHsiung.Location = new System.Drawing.Point(22, 116);
            this.btnKaoHsiung.Name = "btnKaoHsiung";
            this.btnKaoHsiung.Size = new System.Drawing.Size(99, 46);
            this.btnKaoHsiung.TabIndex = 9;
            this.btnKaoHsiung.Text = "高雄市-衛生局";
            this.btnKaoHsiung.UseVisualStyleBackColor = true;
            this.btnKaoHsiung.Click += new System.EventHandler(this.btnKaoHsiung_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(94, 12);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(182, 57);
            this.btnNotify.TabIndex = 8;
            this.btnNotify.Text = "衛生署疾病管制局";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 191);
            this.Controls.Add(this.btnTaipei);
            this.Controls.Add(this.btnTaichung);
            this.Controls.Add(this.btnKaoHsiung);
            this.Controls.Add(this.btnNotify);
            this.Name = "Form1";
            this.Text = "多點傳送委派範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaipei;
        private System.Windows.Forms.Button btnTaichung;
        private System.Windows.Forms.Button btnKaoHsiung;
        private System.Windows.Forms.Button btnNotify;
    }
}

