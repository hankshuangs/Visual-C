namespace ArrayMethod_ex
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
            this.btnSetValue = new System.Windows.Forms.Button();
            this.btnGetValue = new System.Windows.Forms.Button();
            this.btnGetUpperBound = new System.Windows.Forms.Button();
            this.btnGetLowerBound = new System.Windows.Forms.Button();
            this.btnGetLength = new System.Windows.Forms.Button();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetValue
            // 
            this.btnSetValue.Location = new System.Drawing.Point(279, 170);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(230, 54);
            this.btnSetValue.TabIndex = 17;
            this.btnSetValue.Text = "SetValue()－設定陣列元素值";
            this.btnSetValue.UseVisualStyleBackColor = true;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // btnGetValue
            // 
            this.btnGetValue.Location = new System.Drawing.Point(279, 92);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(230, 54);
            this.btnGetValue.TabIndex = 16;
            this.btnGetValue.Text = "GetValue()－獲取陣列元素值";
            this.btnGetValue.UseVisualStyleBackColor = true;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // btnGetUpperBound
            // 
            this.btnGetUpperBound.Location = new System.Drawing.Point(279, 12);
            this.btnGetUpperBound.Name = "btnGetUpperBound";
            this.btnGetUpperBound.Size = new System.Drawing.Size(230, 60);
            this.btnGetUpperBound.TabIndex = 15;
            this.btnGetUpperBound.Text = "GetUpperBound()－取得陣列維度的上限";
            this.btnGetUpperBound.UseVisualStyleBackColor = true;
            this.btnGetUpperBound.Click += new System.EventHandler(this.btnGetUpperBound_Click);
            // 
            // btnGetLowerBound
            // 
            this.btnGetLowerBound.Location = new System.Drawing.Point(27, 170);
            this.btnGetLowerBound.Name = "btnGetLowerBound";
            this.btnGetLowerBound.Size = new System.Drawing.Size(220, 54);
            this.btnGetLowerBound.TabIndex = 14;
            this.btnGetLowerBound.Text = "GetLowerBound()－取得陣列維度的下限";
            this.btnGetLowerBound.UseVisualStyleBackColor = true;
            this.btnGetLowerBound.Click += new System.EventHandler(this.btnGetLowerBound_Click);
            // 
            // btnGetLength
            // 
            this.btnGetLength.Location = new System.Drawing.Point(27, 92);
            this.btnGetLength.Name = "btnGetLength";
            this.btnGetLength.Size = new System.Drawing.Size(220, 54);
            this.btnGetLength.TabIndex = 13;
            this.btnGetLength.Text = "GetLength()－取得陣列的長度";
            this.btnGetLength.UseVisualStyleBackColor = true;
            this.btnGetLength.Click += new System.EventHandler(this.btnGetLength_Click);
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(27, 12);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(220, 60);
            this.btnCopyTo.TabIndex = 12;
            this.btnCopyTo.Text = "CopyTo()－複製陣列元素內容";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 242);
            this.Controls.Add(this.btnSetValue);
            this.Controls.Add(this.btnGetValue);
            this.Controls.Add(this.btnGetUpperBound);
            this.Controls.Add(this.btnGetLowerBound);
            this.Controls.Add(this.btnGetLength);
            this.Controls.Add(this.btnCopyTo);
            this.Name = "Form1";
            this.Text = "陣列常用的方法範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetValue;
        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.Button btnGetUpperBound;
        private System.Windows.Forms.Button btnGetLowerBound;
        private System.Windows.Forms.Button btnGetLength;
        private System.Windows.Forms.Button btnCopyTo;
    }
}

