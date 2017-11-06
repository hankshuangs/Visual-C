namespace LINQtoObjects_ex
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartPrice = new System.Windows.Forms.TextBox();
            this.txtEndPrices = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入查詢大綿羊重機價格範圍?";
            // 
            // txtStartPrice
            // 
            this.txtStartPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStartPrice.Location = new System.Drawing.Point(36, 59);
            this.txtStartPrice.Name = "txtStartPrice";
            this.txtStartPrice.Size = new System.Drawing.Size(100, 22);
            this.txtStartPrice.TabIndex = 1;
            this.txtStartPrice.Text = "450000";
            // 
            // txtEndPrices
            // 
            this.txtEndPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEndPrices.Location = new System.Drawing.Point(159, 59);
            this.txtEndPrices.Name = "txtEndPrices";
            this.txtEndPrices.Size = new System.Drawing.Size(100, 22);
            this.txtEndPrices.TabIndex = 2;
            this.txtEndPrices.Text = "600000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(297, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(88, 49);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LINQtoObjects_ex.Properties.Resources.GTS300i;
            this.ClientSize = new System.Drawing.Size(490, 392);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndPrices);
            this.Controls.Add(this.txtStartPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LINQ to Objects範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartPrice;
        private System.Windows.Forms.TextBox txtEndPrices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
    }
}

