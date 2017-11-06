namespace DataGridView_ex2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tSB_A05 = new System.Windows.Forms.ToolStripButton();
            this.tSB_A06 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSB_A07 = new System.Windows.Forms.ToolStripButton();
            this.tSB_A08 = new System.Windows.Forms.ToolStripButton();
            this.tSB_A04 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_A01 = new System.Windows.Forms.ToolStripButton();
            this.tSB_A02 = new System.Windows.Forms.ToolStripButton();
            this.tSB_A03 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 226);
            this.dataGridView1.TabIndex = 8;
            // 
            // tSB_A05
            // 
            this.tSB_A05.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A05.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A05.Name = "tSB_A05";
            this.tSB_A05.Size = new System.Drawing.Size(147, 22);
            this.tSB_A05.Text = "字型與色彩樣式的設定";
            this.tSB_A05.Click += new System.EventHandler(this.tSB_A05_Click);
            // 
            // tSB_A06
            // 
            this.tSB_A06.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A06.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A06.Name = "tSB_A06";
            this.tSB_A06.Size = new System.Drawing.Size(99, 22);
            this.tSB_A06.Text = "變更格線色彩";
            this.tSB_A06.Click += new System.EventHandler(this.tSB_A06_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_A05,
            this.tSB_A06,
            this.tSB_A07,
            this.tSB_A08});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(676, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSB_A07
            // 
            this.tSB_A07.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A07.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A07.Name = "tSB_A07";
            this.tSB_A07.Size = new System.Drawing.Size(111, 22);
            this.tSB_A07.Text = "儲存格樣式設定";
            this.tSB_A07.Click += new System.EventHandler(this.tSB_A07_Click);
            // 
            // tSB_A08
            // 
            this.tSB_A08.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A08.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A08.Name = "tSB_A08";
            this.tSB_A08.Size = new System.Drawing.Size(135, 22);
            this.tSB_A08.Text = "儲存格框線樣式設定";
            this.tSB_A08.Click += new System.EventHandler(this.tSB_A08_Click);
            // 
            // tSB_A04
            // 
            this.tSB_A04.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A04.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A04.Name = "tSB_A04";
            this.tSB_A04.Size = new System.Drawing.Size(135, 22);
            this.tSB_A04.Text = "文字對齊與自動換行";
            this.tSB_A04.Click += new System.EventHandler(this.tSB_A04_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_A01,
            this.tSB_A02,
            this.tSB_A03,
            this.tSB_A04});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB_A01
            // 
            this.tSB_A01.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A01.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A01.Name = "tSB_A01";
            this.tSB_A01.Size = new System.Drawing.Size(135, 22);
            this.tSB_A01.Text = "依照資料列大小顯示";
            this.tSB_A01.Click += new System.EventHandler(this.tSB_A01_Click);
            // 
            // tSB_A02
            // 
            this.tSB_A02.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A02.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A02.Name = "tSB_A02";
            this.tSB_A02.Size = new System.Drawing.Size(135, 22);
            this.tSB_A02.Text = "替代資料列樣式設定";
            this.tSB_A02.Click += new System.EventHandler(this.tSB_A02_Click);
            // 
            // tSB_A03
            // 
            this.tSB_A03.Image = global::DataGridView_ex2.Properties.Resources.OK;
            this.tSB_A03.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_A03.Name = "tSB_A03";
            this.tSB_A03.Size = new System.Drawing.Size(123, 22);
            this.tSB_A03.Text = "格式化欄位內容值";
            this.tSB_A03.Click += new System.EventHandler(this.tSB_A03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "DataGridView範例程式2-顯示格式設定";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tSB_A05;
        private System.Windows.Forms.ToolStripButton tSB_A06;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tSB_A07;
        private System.Windows.Forms.ToolStripButton tSB_A08;
        private System.Windows.Forms.ToolStripButton tSB_A04;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_A01;
        private System.Windows.Forms.ToolStripButton tSB_A02;
        private System.Windows.Forms.ToolStripButton tSB_A03;
    }
}

