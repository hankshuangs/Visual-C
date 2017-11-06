namespace ArrayClassMethod
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
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(90, 318);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(224, 46);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Sort()－用來「排序」陣列元素";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(90, 246);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(224, 52);
            this.btnReverse.TabIndex = 13;
            this.btnReverse.Text = "Reverse()－用來「反轉」陣列元素";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(90, 169);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(224, 55);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Resize()－用來變更目前陣列的「大小」";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(90, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(224, 58);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear()－用來「清除」指定索引範圍的陣列的元素內容";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(90, 12);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(224, 58);
            this.btnBinarySearch.TabIndex = 10;
            this.btnBinarySearch.Text = "BinarySearch()－用來「搜尋」陣列元素是否符合傳入的參數值";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 377);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBinarySearch);
            this.Name = "Form1";
            this.Text = "陣列類別方法範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBinarySearch;
    }
}

