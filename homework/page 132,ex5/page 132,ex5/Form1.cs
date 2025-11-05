using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace page_132_ex5
{
    public partial class Form1 : Form
    {
        // 你要載入的絕對路徑（如需改成相對路徑或專案資源可在此調整)
        private readonly string HeadsPath = @"C:\Users\m303\Desktop\Heads1.bmp";
        private readonly string TailsPath = @"C:\Users\m303\Desktop\Tails1.bmp";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 啟動時顯示 Heads（若不存在則留空並顯示警告）
            SetPictureFromFile(pictureBoxCoin, HeadsPath);
        }

        private void SetPictureFromFile(PictureBox pb, string path)
        {
            if (!File.Exists(path))
            {
                pb.Image = null;
                // 只在啟動或操作時顯示一次警告；不會每次重繪都跳出
                // 如果你不想在載入時跳警告，可以移除下面這行或改為寫入 log
                MessageBox.Show($"找不到圖檔：{path}\n請確認檔案存在且可讀取。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 以 Image.FromFile 讀取後複製為新 Bitmap，避免鎖檔
                using (var src = Image.FromFile(path))
                {
                    if (pb.Image != null)
                    {
                        var old = pb.Image;
                        pb.Image = null;
                        old.Dispose();
                    }
                    pb.Image = new Bitmap(src);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入圖檔失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowHeads_Click(object sender, EventArgs e)
        {
            SetPictureFromFile(pictureBoxCoin, HeadsPath);
        }

        private void buttonShowTails_Click(object sender, EventArgs e)
        {
            SetPictureFromFile(pictureBoxCoin, TailsPath);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxCoin_Click(object sender, EventArgs e)
        {
            // 可選：點圖可切換 heads/tails（此行為為示範，可自行移除）
            // 若想要啟用，取消下面註解：
            // if (pictureBoxCoin.Image != null && pictureBoxCoin.Image == pictureBox1.Image) { SetPictureFromFile(pictureBoxCoin, HeadsPath); } else { SetPictureFromFile(pictureBoxCoin, TailsPath); }
        }
    }
}
