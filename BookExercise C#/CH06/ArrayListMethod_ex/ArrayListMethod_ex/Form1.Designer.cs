namespace ArrayListMethod_ex
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
            this.btnTrimToSize = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrimToSize
            // 
            this.btnTrimToSize.Location = new System.Drawing.Point(256, 258);
            this.btnTrimToSize.Name = "btnTrimToSize";
            this.btnTrimToSize.Size = new System.Drawing.Size(232, 58);
            this.btnTrimToSize.TabIndex = 23;
            this.btnTrimToSize.Text = "TrimToSize()－將「陣列大小」設定為 ArrayList 中的實際元素數";
            this.btnTrimToSize.UseVisualStyleBackColor = true;
            this.btnTrimToSize.Click += new System.EventHandler(this.btnTrimToSize_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(256, 178);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(232, 62);
            this.btnSort.TabIndex = 22;
            this.btnSort.Text = "Sort()－「排序」整個ArrayList中所有元素的順序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(256, 94);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(232, 65);
            this.btnReverse.TabIndex = 21;
            this.btnReverse.Text = "Reverse()－「反轉」整個 ArrayList 中所有元素的順序";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(256, 3);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(232, 74);
            this.btnRemoveAt.TabIndex = 20;
            this.btnRemoveAt.Text = "RemoveAt()－「移除」 ArrayList 的指定索引位置的元素";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(21, 258);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 58);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove()－「移除」ArrayList特定的第一個符合元素";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(21, 178);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(215, 62);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert()－「新增」物件到指定的ArrayList的索引位置";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(215, 65);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear()－「清除」ArrayList中的所有元素";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 74);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add()－將物件「加入」 ArrayList 位置中的末端";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 330);
            this.Controls.Add(this.btnTrimToSize);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "ArrayList方法範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrimToSize;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
    }
}

