using System;
using System.Windows.Forms;

namespace page_215_ex10
{
    public partial class Form1 : Form
    {
        // 儲存目前總卡路里值的欄位
        private int totalCalories = 0;

        /// <summary>
        /// 建構子：呼叫 InitializeComponent 初始化 UI（由 Designer 產生）
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表單載入事件（目前不需額外處理，但保留以利未來擴充）
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 預設總卡路里顯示為 0（已在 Designer 設定）
            // 若需要額外初始化可在此處加入程式碼
        }

        /// <summary>
        /// 各水果圖片的共同點擊事件處理器。
        /// 我們把卡路里數值放在 PictureBox 的 Tag 屬性（整數），點擊時會將該數值加到 totalCalories 並更新顯示。
        /// </summary>
        private void pictureBoxFruit_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;

            // 嘗試從 Tag 讀取卡路里（設計時已設定為整數）
            if (pb.Tag is int calories)
            {
                totalCalories += calories;
                UpdateTotalDisplay();
            }
            else
            {
                // 若 Tag 未設定或類型錯誤，則不做任何事（可依需求加入錯誤處理）
            }
        }

        /// <summary>
        /// 更新總卡路里顯示（同步到 textBoxTotal）。
        /// </summary>
        private void UpdateTotalDisplay()
        {
            this.textBoxTotal.Text = totalCalories.ToString();
        }

        /// <summary>
        /// 重設按鈕：將總卡路里歸零並更新顯示。
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            UpdateTotalDisplay();
        }

        /// <summary>
        /// 離開按鈕：關閉應用程式視窗。
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelOrangeCalories_Click(object sender, EventArgs e)
        {

        }
    }
}
