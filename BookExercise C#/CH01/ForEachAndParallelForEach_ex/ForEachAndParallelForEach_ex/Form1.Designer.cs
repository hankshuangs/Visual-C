namespace ForEachAndParallelForEach_ex
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
            this.btnForEach = new System.Windows.Forms.Button();
            this.btnParallelForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(45, 51);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(113, 46);
            this.btnForEach.TabIndex = 0;
            this.btnForEach.Text = "ForEach迴圈";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // btnParallelForEach
            // 
            this.btnParallelForEach.Location = new System.Drawing.Point(204, 51);
            this.btnParallelForEach.Name = "btnParallelForEach";
            this.btnParallelForEach.Size = new System.Drawing.Size(186, 46);
            this.btnParallelForEach.TabIndex = 1;
            this.btnParallelForEach.Text = "Parallel.ForEach迴圈";
            this.btnParallelForEach.UseVisualStyleBackColor = true;
            this.btnParallelForEach.Click += new System.EventHandler(this.btnParallelForEach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 162);
            this.Controls.Add(this.btnParallelForEach);
            this.Controls.Add(this.btnForEach);
            this.Name = "Form1";
            this.Text = "ForEach迴圈和Parallel.ForEach迴圈比較範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.Button btnParallelForEach;
    }
}

