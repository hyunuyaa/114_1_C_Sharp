using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_5
{
    // Form1 類別，繼承自 Windows Form
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的控制項
        }

        // 當表單載入時觸發的事件處理函式
        private void Form1_Load(object sender, EventArgs e)
        {
            // 預設將卡牌背面與正面的 PictureBox 隱藏
            cardBackPictureBox.Visible = false;
            cardFacePictureBox.Visible = false;
        }

        // 當「顯示背面」按鈕被點擊時觸發的事件處理函式
        private void showBackButton_Click(object sender, EventArgs e)
        {
            // 顯示卡牌背面的圖片，隱藏卡牌正面的圖片
            cardBackPictureBox.Visible = true;
            cardFacePictureBox.Visible = false;
        }

        // 當「顯示正面」按鈕被點擊時觸發的事件處理函式
        private void showFaceButton_Click(object sender, EventArgs e)
        {
            // 顯示卡牌正面的圖片，隱藏卡牌背面的圖片
            cardBackPictureBox.Visible = false;
            cardFacePictureBox.Visible = true;
        }
    }
}
