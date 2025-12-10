using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    // 主視窗表單類別，負責顯示並切換燈的狀態（開/關）
    public partial class Form1 : Form
    {

        // 建構子：建立表單實例並初始化元件
        public Form1()
        {
            // InitializeComponent 由 Designer 產生，負責建立與配置表單上的控制項 (pictureBox, label, button 等)
            InitializeComponent();
        }

        // switchButton 的 Click 事件處理器
        // 使用者每次按下切換按鈕時會觸發此方法。
        // 依據目前畫面上顯示的圖片 (lightOffPictureBox.Visible) 決定呼叫 turnLightOff 或 turnLightOn。
        // 注意：此處判斷條件是檢查「關燈圖片是否為可見狀態」，然後呼叫對應的方法以設定畫面顯示。
        private void switchButton_Click(object sender, EventArgs e)
        {
           if (lightOffPictureBox.Visible == true)
            {
                // 當「關燈圖片」可見時，呼叫 turnLightOff 以確保顯示為關燈狀態
                turnLightOff();
            }
            else
            {
                // 若「關燈圖片」不可見，表示目前不是關燈畫面，則切換為開燈畫面
                turnLightOn();
            }
        }

        // 將畫面切換至「開燈」狀態
        private void turnLightOn()
        {
            // 顯示代表開燈的圖片（通常是亮燈的圖示）
            lightOnPictureBox.Visible = true;
            // 隱藏代表關燈的圖片
            lightOffPictureBox.Visible = false;
            // 更新狀態標籤為 "ON" 明確表示目前為開燈
            lightStateLabel.Text = "ON";
        }

        // 將畫面切換至「關燈」狀態
        private void turnLightOff()
        {
            // 顯示代表關燈的圖片（通常是暗或關閉的燈圖示）
            lightOffPictureBox.Visible = true;
            // 隱藏代表開燈的圖片
            lightOnPictureBox.Visible = false;
            // 更新狀態標籤為 "OFF" 明確表示目前為關燈
            lightStateLabel.Text = "OFF";
        }

        // exitButton 的 Click 事件處理器
        // 使用者按下離開按鈕時會執行此方法，關閉目前的表單視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單並釋放資源 (如果是主視窗，會結束應用程式)
            this.Close();
        }
    }
}
