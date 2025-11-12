namespace page_213_ex4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 以下為表單上使用的控制項宣告
        private System.Windows.Forms.Label lblGrossIncome;
        private System.Windows.Forms.Label lblStandardDeduction;
        private System.Windows.Forms.Label lblOtherExemptions;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.Label lblTaxPayable;

        private System.Windows.Forms.TextBox txtGrossIncome;
        private System.Windows.Forms.TextBox txtStandardDeduction;
        private System.Windows.Forms.TextBox txtOtherExemptions;
        private System.Windows.Forms.TextBox txtNetIncome;
        private System.Windows.Forms.TextBox txtTaxPayable;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

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
        /// 這個方法的內容。
        /// 
        /// 以下已依使用者要求將元件的 Text 屬性改為繁體中文，
        /// 並將表單的字型設定為「微軟正黑體」(Microsoft JhengHei)，
        /// 字型大小統一改為 18。註解皆以繁體中文說明變更內容與用途。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGrossIncome = new System.Windows.Forms.Label();
            this.lblStandardDeduction = new System.Windows.Forms.Label();
            this.lblOtherExemptions = new System.Windows.Forms.Label();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.lblTaxPayable = new System.Windows.Forms.Label();

            this.txtGrossIncome = new System.Windows.Forms.TextBox();
            this.txtStandardDeduction = new System.Windows.Forms.TextBox();
            this.txtOtherExemptions = new System.Windows.Forms.TextBox();
            this.txtNetIncome = new System.Windows.Forms.TextBox();
            this.txtTaxPayable = new System.Windows.Forms.TextBox();

            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // Form1
            // 
            // AutoScaleDimensions: 表單在不同 DPI 或字型設定下的縮放基準。
            // 這裡維持原先的設定，不須變更。
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            // AutoScaleMode: 指定表單如何依據字型或 DPI 進行縮放。
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // ClientSize: 表單的客戶區大小 (不含邊框與標題列)。
            this.ClientSize = new System.Drawing.Size(800, 450);
            // Name: 表單的程式內識別名稱，不影響 UI 顯示文字。
            this.Name = "Form1";
            // Text: 顯示在視窗標題列的文字，已改為繁體中文「所得稅計算」。
            this.Text = "所得稅計算";
            // Font: 設定表單內元件的預設字型。
            // 設定為微軟正黑體 (Microsoft JhengHei)，字型大小 18，樣式為 Regular，
            // 以確保所有在表單上未明確指定字型的元件，都會使用此字型與大小。
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));

            // ===== Label 與 TextBox 設定 (所有文字均為繁體中文) =====
            // lblGrossIncome: 總收入
            this.lblGrossIncome.AutoSize = true;
            this.lblGrossIncome.Location = new System.Drawing.Point(40, 30);
            this.lblGrossIncome.Name = "lblGrossIncome";
            this.lblGrossIncome.Size = new System.Drawing.Size(120, 30);
            this.lblGrossIncome.TabIndex = 0;
            this.lblGrossIncome.Text = "總收入："; // 繁體中文

            // txtGrossIncome: 輸入總收入
            this.txtGrossIncome.Location = new System.Drawing.Point(260, 25);
            this.txtGrossIncome.Name = "txtGrossIncome";
            this.txtGrossIncome.Size = new System.Drawing.Size(300, 39);
            this.txtGrossIncome.TabIndex = 1;
            this.txtGrossIncome.Text = "0.00";

            // lblStandardDeduction: 標準扣除
            this.lblStandardDeduction.AutoSize = true;
            this.lblStandardDeduction.Location = new System.Drawing.Point(40, 90);
            this.lblStandardDeduction.Name = "lblStandardDeduction";
            this.lblStandardDeduction.Size = new System.Drawing.Size(150, 30);
            this.lblStandardDeduction.TabIndex = 2;
            this.lblStandardDeduction.Text = "標準扣除：";

            // txtStandardDeduction: 輸入標準扣除
            this.txtStandardDeduction.Location = new System.Drawing.Point(260, 85);
            this.txtStandardDeduction.Name = "txtStandardDeduction";
            this.txtStandardDeduction.Size = new System.Drawing.Size(300, 39);
            this.txtStandardDeduction.TabIndex = 3;
            this.txtStandardDeduction.Text = "0.00";

            // lblOtherExemptions: 其他扣除
            this.lblOtherExemptions.AutoSize = true;
            this.lblOtherExemptions.Location = new System.Drawing.Point(40, 150);
            this.lblOtherExemptions.Name = "lblOtherExemptions";
            this.lblOtherExemptions.Size = new System.Drawing.Size(150, 30);
            this.lblOtherExemptions.TabIndex = 4;
            this.lblOtherExemptions.Text = "其他扣除：";

            // txtOtherExemptions: 輸入其他扣除
            this.txtOtherExemptions.Location = new System.Drawing.Point(260, 145);
            this.txtOtherExemptions.Name = "txtOtherExemptions";
            this.txtOtherExemptions.Size = new System.Drawing.Size(300, 39);
            this.txtOtherExemptions.TabIndex = 5;
            this.txtOtherExemptions.Text = "0.00";

            // lblNetIncome: 淨收入（輸出）
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Location = new System.Drawing.Point(40, 210);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(120, 30);
            this.lblNetIncome.TabIndex = 6;
            this.lblNetIncome.Text = "淨收入：";

            // txtNetIncome: 顯示淨收入，設定為唯讀
            this.txtNetIncome.Location = new System.Drawing.Point(260, 205);
            this.txtNetIncome.Name = "txtNetIncome";
            this.txtNetIncome.ReadOnly = true;
            this.txtNetIncome.Size = new System.Drawing.Size(300, 39);
            this.txtNetIncome.TabIndex = 7;
            this.txtNetIncome.Text = "0.00";

            // lblTaxPayable: 應繳稅額（輸出）
            this.lblTaxPayable.AutoSize = true;
            this.lblTaxPayable.Location = new System.Drawing.Point(40, 270);
            this.lblTaxPayable.Name = "lblTaxPayable";
            this.lblTaxPayable.Size = new System.Drawing.Size(150, 30);
            this.lblTaxPayable.TabIndex = 8;
            this.lblTaxPayable.Text = "應繳稅額：";

            // txtTaxPayable: 顯示應繳稅額，設定為唯讀
            this.txtTaxPayable.Location = new System.Drawing.Point(260, 265);
            this.txtTaxPayable.Name = "txtTaxPayable";
            this.txtTaxPayable.ReadOnly = true;
            this.txtTaxPayable.Size = new System.Drawing.Size(300, 39);
            this.txtTaxPayable.TabIndex = 9;
            this.txtTaxPayable.Text = "0.00";

            // ===== Buttons =====
            // btnCalculate: 計算按鈕
            this.btnCalculate.Location = new System.Drawing.Point(120, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 50);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 綁定事件處理器（需在 Form1.cs 實作 btnCalculate_Click）
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear: 清除按鈕
            this.btnClear.Location = new System.Drawing.Point(300, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 50);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnExit: 離開按鈕
            this.btnExit.Location = new System.Drawing.Point(480, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 將所有控制項加入表單
            this.Controls.Add(this.lblGrossIncome);
            this.Controls.Add(this.txtGrossIncome);
            this.Controls.Add(this.lblStandardDeduction);
            this.Controls.Add(this.txtStandardDeduction);
            this.Controls.Add(this.lblOtherExemptions);
            this.Controls.Add(this.txtOtherExemptions);
            this.Controls.Add(this.lblNetIncome);
            this.Controls.Add(this.txtNetIncome);
            this.Controls.Add(this.lblTaxPayable);
            this.Controls.Add(this.txtTaxPayable);

            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);

            // Load 事件: 表單載入時會觸發的事件處理器，若需要初始化邏輯可在 Form1_Load 中實作。
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

