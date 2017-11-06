namespace IfElse_ex
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
            this.btnSuggest = new System.Windows.Forms.Button();
            this.txtoilPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuggest
            // 
            this.btnSuggest.Location = new System.Drawing.Point(59, 114);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(111, 39);
            this.btnSuggest.TabIndex = 11;
            this.btnSuggest.Text = "民意";
            this.btnSuggest.UseVisualStyleBackColor = true;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // txtoilPrice
            // 
            this.txtoilPrice.Location = new System.Drawing.Point(59, 71);
            this.txtoilPrice.Name = "txtoilPrice";
            this.txtoilPrice.Size = new System.Drawing.Size(132, 22);
            this.txtoilPrice.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "請輸入目前九五無鉛汽油每公升多少元?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 186);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.txtoilPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "選擇結構單層if..else範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.TextBox txtoilPrice;
        private System.Windows.Forms.Label label1;
    }
}

