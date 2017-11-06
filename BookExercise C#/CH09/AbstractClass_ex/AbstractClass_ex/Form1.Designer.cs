namespace AbstractClass_ex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInherit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInherit
            // 
            this.btnInherit.Location = new System.Drawing.Point(214, 12);
            this.btnInherit.Name = "btnInherit";
            this.btnInherit.Size = new System.Drawing.Size(100, 38);
            this.btnInherit.TabIndex = 2;
            this.btnInherit.Text = "繼承抽象類別";
            this.btnInherit.UseVisualStyleBackColor = true;
            this.btnInherit.Click += new System.EventHandler(this.btnInherit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(326, 223);
            this.Controls.Add(this.btnInherit);
            this.Name = "Form1";
            this.Text = "抽象類別範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInherit;
    }
}

