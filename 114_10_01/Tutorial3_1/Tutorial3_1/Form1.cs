using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_1
{
    // Form1 類別，繼承自 Windows Forms 的 Form 類別
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的控制項
        }

        // label1 的 Click 事件處理函式
        // 目前未實作任何功能
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // button1 的 Click 事件處理函式
        // 目前未實作任何功能
        private void button1_Click(object sender, EventArgs e)
        {
            dayOfweekTextBox.Text = ""; // 清空 dayOfweekTextBox 的文字
            monthTextBox.Text = "";     // 清空 monthTextBox 的文字
            yearTextBox.Text = "";      // 清空 yearTextBox 的文字
            dayTextBox.Text = "";       // 清空 dayTextBox 的文字
        }

        // showDateButton 的 Click 事件處理函式
        // 取得使用者輸入的日期資訊，並組合成民國日期格式顯示於標籤
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 從對應的 TextBox 取得星期、月份、年份與日期的字串
            string dayOfWeek = dayOfweekTextBox.Text; // 星期幾
            string month = monthTextBox.Text;         // 月份
            string year = yearTextBox.Text;           // 年份（民國年）
            string dayOfMonth = dayTextBox.Text;      // 幾號

            // 組合成民國日期格式的字串
            string output = "中華民國" + year + "年" + month + "月" + dayOfMonth + "日" + "，星期" + dayOfWeek;

            // 將結果顯示在 dateOutputLabel 上
            dateOutputLabel.Text = output;
        }

        // exitButton 的 Click 事件處理函式
        // 關閉目前的表單（結束應用程式）
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉表單
        }
    }
}
