namespace ProjectHash
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
            this.btnCrypto = new System.Windows.Forms.Button();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSHA1 = new System.Windows.Forms.RadioButton();
            this.rdoMD5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCrypto
            // 
            this.btnCrypto.Location = new System.Drawing.Point(202, 19);
            this.btnCrypto.Name = "btnCrypto";
            this.btnCrypto.Size = new System.Drawing.Size(125, 146);
            this.btnCrypto.TabIndex = 23;
            this.btnCrypto.Text = "加密";
            this.btnCrypto.UseVisualStyleBackColor = true;
            this.btnCrypto.Click += new System.EventHandler(this.btnCrypto_Click);
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(39, 207);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(288, 46);
            this.rtxtResult.TabIndex = 22;
            this.rtxtResult.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "加密結果:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(37, 143);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(143, 22);
            this.txtInput.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "請輸入要加密字串:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "請選擇加密演算法";
            // 
            // rdoSHA1
            // 
            this.rdoSHA1.AutoSize = true;
            this.rdoSHA1.Location = new System.Drawing.Point(35, 83);
            this.rdoSHA1.Name = "rdoSHA1";
            this.rdoSHA1.Size = new System.Drawing.Size(51, 16);
            this.rdoSHA1.TabIndex = 17;
            this.rdoSHA1.Text = "SHA1";
            this.rdoSHA1.UseVisualStyleBackColor = true;
            // 
            // rdoMD5
            // 
            this.rdoMD5.AutoSize = true;
            this.rdoMD5.Checked = true;
            this.rdoMD5.Location = new System.Drawing.Point(35, 49);
            this.rdoMD5.Name = "rdoMD5";
            this.rdoMD5.Size = new System.Drawing.Size(47, 16);
            this.rdoMD5.TabIndex = 16;
            this.rdoMD5.TabStop = true;
            this.rdoMD5.Text = "MD5";
            this.rdoMD5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 265);
            this.Controls.Add(this.btnCrypto);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoSHA1);
            this.Controls.Add(this.rdoMD5);
            this.Name = "Form1";
            this.Text = "封裝範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrypto;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSHA1;
        private System.Windows.Forms.RadioButton rdoMD5;
    }
}

