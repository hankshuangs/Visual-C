namespace ArrayListAttribute_ex
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
            this.btnItem = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnCapacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(61, 189);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(188, 61);
            this.btnItem.TabIndex = 8;
            this.btnItem.Text = "Item－用來存取在指定索引位置上的陣列元素";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(61, 101);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(188, 63);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count－用來取得在 ArrayList 中實際所包含的陣列元素個數";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnCapacity
            // 
            this.btnCapacity.Location = new System.Drawing.Point(61, 11);
            this.btnCapacity.Name = "btnCapacity";
            this.btnCapacity.Size = new System.Drawing.Size(188, 64);
            this.btnCapacity.TabIndex = 6;
            this.btnCapacity.Text = "Capacity－用來存取目前 ArrayList 能夠包含的陣列元素個數";
            this.btnCapacity.UseVisualStyleBackColor = true;
            this.btnCapacity.Click += new System.EventHandler(this.btnCapacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnCapacity);
            this.Name = "Form1";
            this.Text = "ArrayList屬性範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnCapacity;
    }
}

