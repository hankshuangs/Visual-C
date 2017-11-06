namespace Namespace_ex
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
            this.btnDeclare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeclare
            // 
            this.btnDeclare.Location = new System.Drawing.Point(53, 32);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(189, 56);
            this.btnDeclare.TabIndex = 2;
            this.btnDeclare.Text = "命名空間宣告";
            this.btnDeclare.UseVisualStyleBackColor = true;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 121);
            this.Controls.Add(this.btnDeclare);
            this.Name = "Form1";
            this.Text = "命名空間宣告範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeclare;
    }
}

