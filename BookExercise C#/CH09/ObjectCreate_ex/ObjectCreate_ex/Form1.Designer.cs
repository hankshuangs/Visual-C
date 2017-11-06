namespace ObjectCreate_ex
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
            this.btnPorsche = new System.Windows.Forms.Button();
            this.btnFerrari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPorsche
            // 
            this.btnPorsche.Location = new System.Drawing.Point(41, 97);
            this.btnPorsche.Name = "btnPorsche";
            this.btnPorsche.Size = new System.Drawing.Size(195, 49);
            this.btnPorsche.TabIndex = 5;
            this.btnPorsche.Text = "建立保時捷物件";
            this.btnPorsche.UseVisualStyleBackColor = true;
            this.btnPorsche.Click += new System.EventHandler(this.btnPorsche_Click);
            // 
            // btnFerrari
            // 
            this.btnFerrari.Location = new System.Drawing.Point(41, 23);
            this.btnFerrari.Name = "btnFerrari";
            this.btnFerrari.Size = new System.Drawing.Size(195, 49);
            this.btnFerrari.TabIndex = 4;
            this.btnFerrari.Text = "建立法拉利物件";
            this.btnFerrari.UseVisualStyleBackColor = true;
            this.btnFerrari.Click += new System.EventHandler(this.btnFerrari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.btnPorsche);
            this.Controls.Add(this.btnFerrari);
            this.Name = "Form1";
            this.Text = "建立物件範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPorsche;
        private System.Windows.Forms.Button btnFerrari;
    }
}

