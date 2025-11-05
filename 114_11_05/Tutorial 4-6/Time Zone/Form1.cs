using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 確認按鈕事件：先檢查是否有選擇城市，沒有則顯示錯誤並結束；有則取得選取項目並透過 switch 設定時區顯示。
        private void okButton_Click(object sender, EventArgs e)
        {
            // 如果沒有選取項目，先顯示錯誤訊息並返回，避免後續使用未初始化變數或執行不必要邏輯
            if (cityListBox.SelectedIndex == -1)
            {
                MessageBox.Show("請先選擇一個城市。", "錯誤");
                return;
            }

            // 此處保證 city 已被指派（因為已確認 SelectedIndex != -1）
            string city = cityListBox.SelectedItem.ToString();

            // 根據選取的城市設定對應時區文字
            switch (city)
            {
                case "紐約":
                    timeZoneLabel.Text = "東部標準時間";
                    break;
                case "檀香山":
                    timeZoneLabel.Text = "夏威夷標準時間";
                    break;
                case "明尼阿波里斯":
                    timeZoneLabel.Text = "中部標準時間";
                    break;
                case "丹佛":
                    timeZoneLabel.Text = "山地標準時間";
                    break;
                case "舊金山":
                    timeZoneLabel.Text = "太平洋標準時間";
                    break;
                default:
                    // 若未符合任何已知城市，可以清空或顯示預設訊息
                    timeZoneLabel.Text = "";
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
