using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page_213_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 計算按鈕處理程序
        /// 1. 讀取總收入、標準扣除、其他扣除的輸入文字
        /// 2. 嘗試轉換為 double，若失敗則顯示錯誤訊息
        /// 3. 計算淨收入 = 總收入 - 標準扣除 - 其他扣除
        /// 4. 若淨收入小於等於 0，應繳稅額為 0；否則依稅率 15% 計算
        /// 5. 將結果格式化為數值顯示在對應的唯讀文字方塊
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 使用系統文化解析數字，讓小數點與千分位符合使用者區域設定
            double gross, standardDeduction, otherExemptions;

            // 依序嘗試解析使用者輸入，若任何一項失敗則提示並返回
            if (!double.TryParse(txtGrossIncome.Text, out gross))
            {
                MessageBox.Show("請輸入有效的總收入數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrossIncome.Focus();
                return;
            }

            if (!double.TryParse(txtStandardDeduction.Text, out standardDeduction))
            {
                MessageBox.Show("請輸入有效的標準扣除數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStandardDeduction.Focus();
                return;
            }

            if (!double.TryParse(txtOtherExemptions.Text, out otherExemptions))
            {
                MessageBox.Show("請輸入有效的其他扣除數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOtherExemptions.Focus();
                return;
            }

            // 計算淨收入與應繳稅額
            double netIncome = gross - standardDeduction - otherExemptions;
            if (netIncome < 0) netIncome = 0; // 負值視為 0

            const double taxRate = 0.15; // 稅率 15%
            double taxPayable = netIncome * taxRate;

            // 顯示結果，保留兩位小數
            txtNetIncome.Text = netIncome.ToString("N2");
            txtTaxPayable.Text = taxPayable.ToString("N2");
        }

        /// <summary>
        /// 清除按鈕處理程序
        /// 將輸入欄位與輸出欄位重設為預設值
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrossIncome.Text = "0.00";
            txtStandardDeduction.Text = "0.00";
            txtOtherExemptions.Text = "0.00";
            txtNetIncome.Text = "0.00";
            txtTaxPayable.Text = "0.00";

            txtGrossIncome.Focus();
        }

        /// <summary>
        /// 離開按鈕處理程序
        /// 關閉應用程式
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
