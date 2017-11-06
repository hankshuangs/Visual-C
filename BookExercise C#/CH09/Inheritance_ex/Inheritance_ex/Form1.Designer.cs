namespace Inheritance_ex
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
            this.btnTurbo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurbo
            // 
            this.btnTurbo.Location = new System.Drawing.Point(12, 12);
            this.btnTurbo.Name = "btnTurbo";
            this.btnTurbo.Size = new System.Drawing.Size(105, 39);
            this.btnTurbo.TabIndex = 2;
            this.btnTurbo.Text = "加裝渦輪系統";
            this.btnTurbo.UseVisualStyleBackColor = true;
            this.btnTurbo.Click += new System.EventHandler(this.btnTurbo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inheritance_ex.Properties.Resources.Eclipse2014;
            this.ClientSize = new System.Drawing.Size(392, 212);
            this.Controls.Add(this.btnTurbo);
            this.Name = "Form1";
            this.Text = "單一繼承範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTurbo;
    }
}

