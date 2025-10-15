using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當「資格審查」按鈕被點擊時執行此事件
        // 可在此方法內加入貸款資格判斷的邏輯
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 尚未實作資格審查邏輯
            const decimal MINIMUM_SALARY = 120000m; // 最低年薪要求
            const int MINIMUM_YEARS = 2; // 最低年資要求

            decimal salary; // 用於存放使用者輸入的年薪
            int years; // 用於存放使用者輸入的年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text); //將輸入年薪轉換為decimal
                years = int.Parse(yearsTextBox.Text); //將輸入年資轉換為int

                // 判斷年薪是否符合貸款資格
                if (salary >= MINIMUM_SALARY)
                {
                    if (years >= MINIMUM_YEARS)
                    {
                        decisionLabel.Text = "符合資格"; // 顯示符合資格
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格，年資未達最低標準"; // 顯示不符合資格
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格，年資未達最低標準"; // 顯示不符合資格
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// 顯示錯誤訊息
            }
        }

        // 當「清除」按鈕被點擊時執行此事件
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪輸入框
            salaryTextBox.Text = "";
            // 清空年資輸入框
            yearsTextBox.Text = "";
            // 清空結果顯示標籤
            decisionLabel.Text = "";

            // 將游標焦點移回年薪輸入框，方便使用者重新輸入
            salaryTextBox.Focus();
        }

        // 當「離開」按鈕被點擊時執行此事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
