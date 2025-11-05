using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page_131_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定表單與所有控制項字型為「微軟正黑體」18pt
            var uiFont = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
            this.Font = uiFont;
            ApplyFontToControls(this.Controls, uiFont);

            // 不要用 Image.FromFile 覆寫 designer 的 resource 圖片，會造成 FileNotFoundException
            // Designer 已經將圖嵌入到 Properties.Resources，直接使用即可

            // 設定 Tag 為卡片名稱（不含副檔名），供點擊時顯示
            pictureBox1.Tag = "黑桃4";
            pictureBox2.Tag = "紅心7";
            pictureBox3.Tag = "菱形A";
            pictureBox4.Tag = "梅花J";
            pictureBox5.Tag = "黑色鬼牌";

            // 維持圖片大小比例（designer 已設定，此處冗餘也沒問題）
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Text = "表單1";
            if (label1 != null) label1.Text = ""; // 初始文字
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            var clickedCard = sender as PictureBox;
            if (clickedCard == null) return;

            // 優先使用 Tag（已在 Load 設定），再用 ImageLocation，最後用 Name
            if (clickedCard.Tag != null)
            {
                label1.Text = "您點擊了：" + clickedCard.Tag.ToString();
                return;
            }

            if (!string.IsNullOrEmpty(clickedCard.ImageLocation))
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(clickedCard.ImageLocation);
                label1.Text = "您點擊了：" + fileName;
                return;
            }

            label1.Text = "您點擊了：" + clickedCard.Name;
        }

        // 遞迴套用字型到所有控制項
        private void ApplyFontToControls(Control.ControlCollection controls, Font font)
        {
            foreach (Control c in controls)
            {
                c.Font = font;
                if (c.HasChildren)
                {
                    ApplyFontToControls(c.Controls, font);
                }
            }
        }
    }
}
