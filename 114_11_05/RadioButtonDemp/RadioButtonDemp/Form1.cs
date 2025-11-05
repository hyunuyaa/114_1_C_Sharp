using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CoffeeradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:";
            String drink = "";
            String food = "";

            if (CoffeeradioButton.Checked)
            {
                drink = "咖啡 ";
            }
            else if (BlacktearadioButton.Checked)
            {
                drink = "紅茶 ";
            }
            else if (MilktearadioButton.Checked)
            {
                drink = "奶茶 ";
            }
            else if (JuiceradioButton.Checked)
            {
                drink = "果汁 ";
            }
            else
            {
                drink = "未選擇飲料 ";
            }

            if (SandwichradioButton.Checked)
            {
                food = "三明治 ";
            }
            else if (BurgerradioButton.Checked)
            {
                food = "漢堡 ";
            }
            else if (ToastradioButton.Checked)
            {
                food = "吐司 ";
            }
            else
            {
                food = "未選擇餐點 ";
            }

            message += drink + food;
            MessageBox.Show(message, "您的點餐內容");
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
