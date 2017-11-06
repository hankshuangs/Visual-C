namespace DataSet_ex
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new DataSet_ex.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oilPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oilPriceTableAdapter = new DataSet_ex.DataSet1TableAdapters.oilPriceTableAdapter();
            this.產品編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.產品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.參考牌價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.產品編號DataGridViewTextBoxColumn,
            this.產品名稱DataGridViewTextBoxColumn,
            this.參考牌價DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oilPriceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(350, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // oilPriceBindingSource
            // 
            this.oilPriceBindingSource.DataMember = "oilPrice";
            this.oilPriceBindingSource.DataSource = this.dataSet1;
            // 
            // oilPriceTableAdapter
            // 
            this.oilPriceTableAdapter.ClearBeforeFill = true;
            // 
            // 產品編號DataGridViewTextBoxColumn
            // 
            this.產品編號DataGridViewTextBoxColumn.DataPropertyName = "產品編號";
            this.產品編號DataGridViewTextBoxColumn.HeaderText = "產品編號";
            this.產品編號DataGridViewTextBoxColumn.Name = "產品編號DataGridViewTextBoxColumn";
            // 
            // 產品名稱DataGridViewTextBoxColumn
            // 
            this.產品名稱DataGridViewTextBoxColumn.DataPropertyName = "產品名稱";
            this.產品名稱DataGridViewTextBoxColumn.HeaderText = "產品名稱";
            this.產品名稱DataGridViewTextBoxColumn.Name = "產品名稱DataGridViewTextBoxColumn";
            // 
            // 參考牌價DataGridViewTextBoxColumn
            // 
            this.參考牌價DataGridViewTextBoxColumn.DataPropertyName = "參考牌價";
            this.參考牌價DataGridViewTextBoxColumn.HeaderText = "參考牌價";
            this.參考牌價DataGridViewTextBoxColumn.Name = "參考牌價DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 197);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DataSet元件範例程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilPriceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource oilPriceBindingSource;
        private DataSet1TableAdapters.oilPriceTableAdapter oilPriceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 參考牌價DataGridViewTextBoxColumn;
    }
}

