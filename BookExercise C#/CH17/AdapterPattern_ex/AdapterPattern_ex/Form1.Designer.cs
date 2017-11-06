namespace AdapterPattern_ex
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnAdapterProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(47, 33);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(113, 52);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "正常處理";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnAdapterProcess
            // 
            this.btnAdapterProcess.Location = new System.Drawing.Point(210, 33);
            this.btnAdapterProcess.Name = "btnAdapterProcess";
            this.btnAdapterProcess.Size = new System.Drawing.Size(119, 52);
            this.btnAdapterProcess.TabIndex = 1;
            this.btnAdapterProcess.Text = "轉接器處理";
            this.btnAdapterProcess.UseVisualStyleBackColor = true;
            this.btnAdapterProcess.Click += new System.EventHandler(this.btnAdapterProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 118);
            this.Controls.Add(this.btnAdapterProcess);
            this.Controls.Add(this.btnProcess);
            this.Name = "Form1";
            this.Text = "Adapter Pattern範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnAdapterProcess;
    }
}

