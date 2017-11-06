namespace OptionalArgument_ex
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
            this.btnCompute2 = new System.Windows.Forms.Button();
            this.btnCompute1 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompute2
            // 
            this.btnCompute2.Location = new System.Drawing.Point(177, 100);
            this.btnCompute2.Name = "btnCompute2";
            this.btnCompute2.Size = new System.Drawing.Size(124, 43);
            this.btnCompute2.TabIndex = 7;
            this.btnCompute2.Text = "計算2";
            this.btnCompute2.UseVisualStyleBackColor = true;
            this.btnCompute2.Click += new System.EventHandler(this.btnCompute2_Click);
            // 
            // btnCompute1
            // 
            this.btnCompute1.Location = new System.Drawing.Point(46, 99);
            this.btnCompute1.Name = "btnCompute1";
            this.btnCompute1.Size = new System.Drawing.Size(125, 44);
            this.btnCompute1.TabIndex = 6;
            this.btnCompute1.Text = "計算1";
            this.btnCompute1.UseVisualStyleBackColor = true;
            this.btnCompute1.Click += new System.EventHandler(this.btnCompute1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(45, 62);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(256, 22);
            this.txtN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "加總計算(1+2+..10)，結果如下:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 173);
            this.Controls.Add(this.btnCompute2);
            this.Controls.Add(this.btnCompute1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "選擇性引數範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute2;
        private System.Windows.Forms.Button btnCompute1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
    }
}

