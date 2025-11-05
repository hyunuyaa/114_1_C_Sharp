namespace page_132_ex5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBoxCoin;
        private System.Windows.Forms.Button buttonShowHeads;
        private System.Windows.Forms.Button buttonShowTails;
        private System.Windows.Forms.Button buttonExit;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (pictureBoxCoin != null && pictureBoxCoin.Image != null)
                {
                    pictureBoxCoin.Image.Dispose();
                    pictureBoxCoin.Image = null;
                }
                if (pictureBox1 != null && pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowHeads = new System.Windows.Forms.Button();
            this.buttonShowTails = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowHeads
            // 
            this.buttonShowHeads.Location = new System.Drawing.Point(60, 300);
            this.buttonShowHeads.Name = "buttonShowHeads";
            this.buttonShowHeads.Size = new System.Drawing.Size(110, 36);
            this.buttonShowHeads.TabIndex = 1;
            this.buttonShowHeads.Text = "Show Heads";
            this.buttonShowHeads.UseVisualStyleBackColor = true;
            this.buttonShowHeads.Click += new System.EventHandler(this.buttonShowHeads_Click);
            // 
            // buttonShowTails
            // 
            this.buttonShowTails.Location = new System.Drawing.Point(190, 300);
            this.buttonShowTails.Name = "buttonShowTails";
            this.buttonShowTails.Size = new System.Drawing.Size(110, 36);
            this.buttonShowTails.TabIndex = 2;
            this.buttonShowTails.Text = "Show Tails";
            this.buttonShowTails.UseVisualStyleBackColor = true;
            this.buttonShowTails.Click += new System.EventHandler(this.buttonShowTails_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(320, 300);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 36);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            // Image 指定已移除，改由 Form_Load 動態載入
            this.pictureBox1.Location = new System.Drawing.Point(246, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCoin
            // 
            // Image 指定已移除，改由 Form_Load 動態載入
            this.pictureBoxCoin.Location = new System.Drawing.Point(41, 31);
            this.pictureBoxCoin.Name = "pictureBoxCoin";
            this.pictureBoxCoin.Size = new System.Drawing.Size(168, 234);
            this.pictureBoxCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCoin.TabIndex = 0;
            this.pictureBoxCoin.TabStop = false;
            this.pictureBoxCoin.Click += new System.EventHandler(this.pictureBoxCoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowTails);
            this.Controls.Add(this.buttonShowHeads);
            this.Controls.Add(this.pictureBoxCoin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heads or Tails";
            // 將載入圖片的邏輯綁到表單 Load 事件（在 Form1.cs 中實作）
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

