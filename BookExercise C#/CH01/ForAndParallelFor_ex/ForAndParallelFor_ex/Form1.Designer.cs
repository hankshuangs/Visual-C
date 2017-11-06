namespace ForAndParallelFor_ex
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnParallelFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(46, 35);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(139, 50);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "For迴圈";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnParallelFor
            // 
            this.btnParallelFor.Location = new System.Drawing.Point(222, 35);
            this.btnParallelFor.Name = "btnParallelFor";
            this.btnParallelFor.Size = new System.Drawing.Size(168, 50);
            this.btnParallelFor.TabIndex = 1;
            this.btnParallelFor.Text = "Parallel.For迴圈";
            this.btnParallelFor.UseVisualStyleBackColor = true;
            this.btnParallelFor.Click += new System.EventHandler(this.btnParallelFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 122);
            this.Controls.Add(this.btnParallelFor);
            this.Controls.Add(this.btnFor);
            this.Name = "Form1";
            this.Text = "For迴圈和Parallel.For迴圈比較範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnParallelFor;
    }
}

