namespace page_215_ex10
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數（由 Visual Studio 管理）。
        /// 此檔由程式手動產生 UI 設定：
        /// - 將所有可見文字改為繁體中文
        /// - 將預設字型改為 18pt（微軟正黑體）
        /// - 初始化四個 PictureBox、對應的卡路里 Label、總卡路里顯示與按鈕
        /// 注意：若您使用 Visual Studio Designer 編輯表單，Designer 可能會覆寫此檔案的變更。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 控制項宣告（僅宣告一次）
        private System.Windows.Forms.PictureBox pictureBoxBanana;
        private System.Windows.Forms.PictureBox pictureBoxApple;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxPear;

        private System.Windows.Forms.Label labelBananaCalories;
        private System.Windows.Forms.Label labelAppleCalories;
        private System.Windows.Forms.Label labelOrangeCalories;
        private System.Windows.Forms.Label labelPearCalories;

        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。此處以程式碼建立完整 UI，並以繁體中文註解說明每段設定。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBanana = new System.Windows.Forms.PictureBox();
            this.pictureBoxApple = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxPear = new System.Windows.Forms.PictureBox();
            this.labelBananaCalories = new System.Windows.Forms.Label();
            this.labelAppleCalories = new System.Windows.Forms.Label();
            this.labelOrangeCalories = new System.Windows.Forms.Label();
            this.labelPearCalories = new System.Windows.Forms.Label();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPear)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBanana
            // 
            this.pictureBoxBanana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBanana.Image = global::page_215_ex10.Properties.Resources.Banana;
            this.pictureBoxBanana.Location = new System.Drawing.Point(36, 20);
            this.pictureBoxBanana.Name = "pictureBoxBanana";
            this.pictureBoxBanana.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBanana.TabIndex = 0;
            this.pictureBoxBanana.TabStop = false;
            this.pictureBoxBanana.Tag = 115;
            this.pictureBoxBanana.Click += new System.EventHandler(this.pictureBoxFruit_Click);
            // 
            // pictureBoxApple
            // 
            this.pictureBoxApple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxApple.Image = global::page_215_ex10.Properties.Resources.Apple;
            this.pictureBoxApple.Location = new System.Drawing.Point(264, 23);
            this.pictureBoxApple.Name = "pictureBoxApple";
            this.pictureBoxApple.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxApple.TabIndex = 1;
            this.pictureBoxApple.TabStop = false;
            this.pictureBoxApple.Tag = 80;
            this.pictureBoxApple.Click += new System.EventHandler(this.pictureBoxFruit_Click);
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOrange.Image = global::page_215_ex10.Properties.Resources.Orange;
            this.pictureBoxOrange.Location = new System.Drawing.Point(46, 214);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOrange.TabIndex = 2;
            this.pictureBoxOrange.TabStop = false;
            this.pictureBoxOrange.Tag = 90;
            this.pictureBoxOrange.Click += new System.EventHandler(this.pictureBoxFruit_Click);
            // 
            // pictureBoxPear
            // 
            this.pictureBoxPear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPear.Image = global::page_215_ex10.Properties.Resources.Pear;
            this.pictureBoxPear.Location = new System.Drawing.Point(264, 214);
            this.pictureBoxPear.Name = "pictureBoxPear";
            this.pictureBoxPear.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPear.TabIndex = 3;
            this.pictureBoxPear.TabStop = false;
            this.pictureBoxPear.Tag = 120;
            this.pictureBoxPear.Click += new System.EventHandler(this.pictureBoxFruit_Click);
            // 
            // labelBananaCalories
            // 
            this.labelBananaCalories.Location = new System.Drawing.Point(12, 156);
            this.labelBananaCalories.Name = "labelBananaCalories";
            this.labelBananaCalories.Size = new System.Drawing.Size(209, 45);
            this.labelBananaCalories.TabIndex = 4;
            this.labelBananaCalories.Text = "115 卡路里";
            this.labelBananaCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAppleCalories
            // 
            this.labelAppleCalories.Location = new System.Drawing.Point(230, 156);
            this.labelAppleCalories.Name = "labelAppleCalories";
            this.labelAppleCalories.Size = new System.Drawing.Size(201, 45);
            this.labelAppleCalories.TabIndex = 5;
            this.labelAppleCalories.Text = "80 卡路里";
            this.labelAppleCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrangeCalories
            // 
            this.labelOrangeCalories.Location = new System.Drawing.Point(12, 347);
            this.labelOrangeCalories.Name = "labelOrangeCalories";
            this.labelOrangeCalories.Size = new System.Drawing.Size(209, 44);
            this.labelOrangeCalories.TabIndex = 6;
            this.labelOrangeCalories.Text = "90 卡路里";
            this.labelOrangeCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrangeCalories.Click += new System.EventHandler(this.labelOrangeCalories_Click);
            // 
            // labelPearCalories
            // 
            this.labelPearCalories.Location = new System.Drawing.Point(222, 347);
            this.labelPearCalories.Name = "labelPearCalories";
            this.labelPearCalories.Size = new System.Drawing.Size(209, 44);
            this.labelPearCalories.TabIndex = 7;
            this.labelPearCalories.Text = "120 卡路里";
            this.labelPearCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Location = new System.Drawing.Point(429, 52);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(200, 45);
            this.labelTotalText.TabIndex = 8;
            this.labelTotalText.Text = "總卡路里：";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(437, 123);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(192, 55);
            this.textBoxTotal.TabIndex = 9;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(437, 209);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(194, 80);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "重設";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(437, 311);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(194, 80);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 447);
            this.Controls.Add(this.pictureBoxBanana);
            this.Controls.Add(this.pictureBoxApple);
            this.Controls.Add(this.pictureBoxOrange);
            this.Controls.Add(this.pictureBoxPear);
            this.Controls.Add(this.labelBananaCalories);
            this.Controls.Add(this.labelAppleCalories);
            this.Controls.Add(this.labelOrangeCalories);
            this.Controls.Add(this.labelPearCalories);
            this.Controls.Add(this.labelTotalText);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "卡路里計算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
