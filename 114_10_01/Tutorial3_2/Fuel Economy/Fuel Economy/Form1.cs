using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 當使用者點擊「計算每公升公里數」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告一個 double 變數來儲存公里數（目前未使用）
            double kilometers; 
            // 宣告一個 double 變數來儲存公升數
            double liters; 
            // 宣告一個 double 變數來儲存每公升公里數
            double kmpl; 

            // 讀取使用者輸入的公里數並轉換為 double
            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);

            // 計算每公升公里數
            kmpl = kilometers / liters;

            // 顯示結果
            mpgLabel.Text = kmpl.ToString("n2") + " 公里/公升";

        }

        // 當使用者點擊「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
