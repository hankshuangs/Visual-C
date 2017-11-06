namespace DataView_ex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Combo_SortItem = new System.Windows.Forms.ComboBox();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Combo_QueryItem = new System.Windows.Forms.ComboBox();
            this.rdobtn_ASC = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.rdobtn_DESC = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 90);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(730, 226);
            this.DataGridView1.TabIndex = 34;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Combo_SortItem);
            this.GroupBox2.Location = new System.Drawing.Point(191, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(167, 72);
            this.GroupBox2.TabIndex = 31;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "排序項目";
            // 
            // Combo_SortItem
            // 
            this.Combo_SortItem.FormattingEnabled = true;
            this.Combo_SortItem.Items.AddRange(new object[] {
            "歌曲編號",
            "歌名",
            "歌手",
            "語言",
            "發行日期",
            "目前名次"});
            this.Combo_SortItem.Location = new System.Drawing.Point(21, 28);
            this.Combo_SortItem.Name = "Combo_SortItem";
            this.Combo_SortItem.Size = new System.Drawing.Size(123, 20);
            this.Combo_SortItem.TabIndex = 0;
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(7, 28);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(126, 22);
            this.txt_keyword.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Combo_QueryItem);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(162, 69);
            this.GroupBox1.TabIndex = 30;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "查詢項目";
            // 
            // Combo_QueryItem
            // 
            this.Combo_QueryItem.FormattingEnabled = true;
            this.Combo_QueryItem.Items.AddRange(new object[] {
            "歌曲編號",
            "歌名",
            "歌手",
            "語言",
            "發行日期",
            "目前名次"});
            this.Combo_QueryItem.Location = new System.Drawing.Point(18, 29);
            this.Combo_QueryItem.Name = "Combo_QueryItem";
            this.Combo_QueryItem.Size = new System.Drawing.Size(122, 20);
            this.Combo_QueryItem.TabIndex = 0;
            // 
            // rdobtn_ASC
            // 
            this.rdobtn_ASC.AutoSize = true;
            this.rdobtn_ASC.Checked = true;
            this.rdobtn_ASC.Location = new System.Drawing.Point(6, 21);
            this.rdobtn_ASC.Name = "rdobtn_ASC";
            this.rdobtn_ASC.Size = new System.Drawing.Size(103, 16);
            this.rdobtn_ASC.TabIndex = 0;
            this.rdobtn_ASC.TabStop = true;
            this.rdobtn_ASC.Text = "由小到大(遞增)";
            this.rdobtn_ASC.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.rdobtn_DESC);
            this.GroupBox3.Controls.Add(this.rdobtn_ASC);
            this.GroupBox3.Location = new System.Drawing.Point(380, 13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(128, 68);
            this.GroupBox3.TabIndex = 32;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "排序方式";
            // 
            // rdobtn_DESC
            // 
            this.rdobtn_DESC.AutoSize = true;
            this.rdobtn_DESC.Location = new System.Drawing.Point(6, 43);
            this.rdobtn_DESC.Name = "rdobtn_DESC";
            this.rdobtn_DESC.Size = new System.Drawing.Size(103, 16);
            this.rdobtn_DESC.TabIndex = 1;
            this.rdobtn_DESC.Text = "由大到小(遞減)";
            this.rdobtn_DESC.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txt_keyword);
            this.GroupBox4.Location = new System.Drawing.Point(531, 13);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(139, 71);
            this.GroupBox4.TabIndex = 33;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "輸入查詢關鍵字";
            // 
            // btn_query
            // 
            this.btn_query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_query.BackgroundImage")));
            this.btn_query.Location = new System.Drawing.Point(676, 34);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(66, 42);
            this.btn_query.TabIndex = 29;
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 327);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.btn_query);
            this.Name = "Form1";
            this.Text = "DataView範例程式-音樂查榜系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox Combo_SortItem;
        internal System.Windows.Forms.TextBox txt_keyword;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox Combo_QueryItem;
        internal System.Windows.Forms.RadioButton rdobtn_ASC;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.RadioButton rdobtn_DESC;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btn_query;
    }
}

