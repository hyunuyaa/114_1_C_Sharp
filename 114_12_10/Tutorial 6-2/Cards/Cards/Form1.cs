using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
           if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
           else
            {
                MessageBox.Show("Please select a card from the list.");
            }
        }

        private void showSelectedCard(string cardName)
        {
            switch (cardName)
            {
                case "Ace of Spades":
                    break;
                case "King of Hearts":
                    break;
                case "Queen of Diamonds":
                    break;
                case "Jack of Clubs":
                    break;
                default:
                    MessageBox.Show("Card image not found.");
                    break;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aceSpadesPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
