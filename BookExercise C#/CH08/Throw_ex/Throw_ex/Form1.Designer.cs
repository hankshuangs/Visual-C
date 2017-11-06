namespace Throw_ex
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labFive = new System.Windows.Forms.Label();
            this.labFour = new System.Windows.Forms.Label();
            this.labThree = new System.Windows.Forms.Label();
            this.labTwo = new System.Windows.Forms.Label();
            this.labOne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(239, 66);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 57);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(239, 24);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 22;
            // 
            // labFive
            // 
            this.labFive.AutoSize = true;
            this.labFive.Location = new System.Drawing.Point(26, 167);
            this.labFive.Name = "labFive";
            this.labFive.Size = new System.Drawing.Size(97, 12);
            this.labFive.TabIndex = 21;
            this.labFive.Text = "5. Xciting-KYMCO";
            // 
            // labFour
            // 
            this.labFour.AutoSize = true;
            this.labFour.Location = new System.Drawing.Point(26, 138);
            this.labFour.Name = "labFour";
            this.labFour.Size = new System.Drawing.Size(87, 12);
            this.labFour.TabIndex = 20;
            this.labFour.Text = "4. AN650-Suzuki";
            // 
            // labThree
            // 
            this.labThree.AutoSize = true;
            this.labThree.Location = new System.Drawing.Point(26, 111);
            this.labThree.Name = "labThree";
            this.labThree.Size = new System.Drawing.Size(76, 12);
            this.labThree.TabIndex = 19;
            this.labThree.Text = "3. C650-BMW";
            // 
            // labTwo
            // 
            this.labTwo.AutoSize = true;
            this.labTwo.Location = new System.Drawing.Point(26, 81);
            this.labTwo.Name = "labTwo";
            this.labTwo.Size = new System.Drawing.Size(90, 12);
            this.labTwo.TabIndex = 18;
            this.labTwo.Text = "2. T-max-Yamaha";
            // 
            // labOne
            // 
            this.labOne.AutoSize = true;
            this.labOne.Location = new System.Drawing.Point(28, 51);
            this.labOne.Name = "labOne";
            this.labOne.Size = new System.Drawing.Size(87, 12);
            this.labOne.TabIndex = 17;
            this.labOne.Text = "1. GTS300i-SYM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "請輸入數字1~5選擇您喜愛的重機大羊";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Throw_ex.Properties.Resources.GTS300i;
            this.ClientSize = new System.Drawing.Size(474, 249);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.labFive);
            this.Controls.Add(this.labFour);
            this.Controls.Add(this.labThree);
            this.Controls.Add(this.labTwo);
            this.Controls.Add(this.labOne);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "throw範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label labFive;
        private System.Windows.Forms.Label labFour;
        private System.Windows.Forms.Label labThree;
        private System.Windows.Forms.Label labTwo;
        private System.Windows.Forms.Label labOne;
        private System.Windows.Forms.Label label1;
    }
}

