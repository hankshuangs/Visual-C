namespace Generics_ex
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
            this.btnGenericsClass = new System.Windows.Forms.Button();
            this.btnGenericsMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenericsClass
            // 
            this.btnGenericsClass.Location = new System.Drawing.Point(52, 118);
            this.btnGenericsClass.Name = "btnGenericsClass";
            this.btnGenericsClass.Size = new System.Drawing.Size(154, 48);
            this.btnGenericsClass.TabIndex = 5;
            this.btnGenericsClass.Text = "泛型類別";
            this.btnGenericsClass.UseVisualStyleBackColor = true;
            this.btnGenericsClass.Click += new System.EventHandler(this.btnGenericsClass_Click);
            // 
            // btnGenericsMethod
            // 
            this.btnGenericsMethod.Location = new System.Drawing.Point(52, 35);
            this.btnGenericsMethod.Name = "btnGenericsMethod";
            this.btnGenericsMethod.Size = new System.Drawing.Size(154, 50);
            this.btnGenericsMethod.TabIndex = 4;
            this.btnGenericsMethod.Text = "泛型方法";
            this.btnGenericsMethod.UseVisualStyleBackColor = true;
            this.btnGenericsMethod.Click += new System.EventHandler(this.btnGenericsMethod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.btnGenericsClass);
            this.Controls.Add(this.btnGenericsMethod);
            this.Name = "Form1";
            this.Text = "泛型範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenericsClass;
        private System.Windows.Forms.Button btnGenericsMethod;
    }
}

