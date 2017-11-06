namespace ImplicitlyTypedArray
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
            this.btnImplicitlyAnonymous = new System.Windows.Forms.Button();
            this.btnTwoArray = new System.Windows.Forms.Button();
            this.btnOneArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImplicitlyAnonymous
            // 
            this.btnImplicitlyAnonymous.Location = new System.Drawing.Point(33, 151);
            this.btnImplicitlyAnonymous.Name = "btnImplicitlyAnonymous";
            this.btnImplicitlyAnonymous.Size = new System.Drawing.Size(214, 51);
            this.btnImplicitlyAnonymous.TabIndex = 8;
            this.btnImplicitlyAnonymous.Text = "隱含型別搭配匿名型別";
            this.btnImplicitlyAnonymous.UseVisualStyleBackColor = true;
            this.btnImplicitlyAnonymous.Click += new System.EventHandler(this.btnImplicitlyAnonymous_Click);
            // 
            // btnTwoArray
            // 
            this.btnTwoArray.Location = new System.Drawing.Point(33, 81);
            this.btnTwoArray.Name = "btnTwoArray";
            this.btnTwoArray.Size = new System.Drawing.Size(214, 50);
            this.btnTwoArray.TabIndex = 7;
            this.btnTwoArray.Text = "二維陣列隱含型別陣列";
            this.btnTwoArray.UseVisualStyleBackColor = true;
            this.btnTwoArray.Click += new System.EventHandler(this.btnTwoArray_Click);
            // 
            // btnOneArray
            // 
            this.btnOneArray.Location = new System.Drawing.Point(33, 12);
            this.btnOneArray.Name = "btnOneArray";
            this.btnOneArray.Size = new System.Drawing.Size(214, 49);
            this.btnOneArray.TabIndex = 6;
            this.btnOneArray.Text = "一維陣列隱含型別陣列";
            this.btnOneArray.UseVisualStyleBackColor = true;
            this.btnOneArray.Click += new System.EventHandler(this.btnOneArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.btnImplicitlyAnonymous);
            this.Controls.Add(this.btnTwoArray);
            this.Controls.Add(this.btnOneArray);
            this.Name = "Form1";
            this.Text = "隱含型別陣列範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImplicitlyAnonymous;
        private System.Windows.Forms.Button btnTwoArray;
        private System.Windows.Forms.Button btnOneArray;
    }
}

