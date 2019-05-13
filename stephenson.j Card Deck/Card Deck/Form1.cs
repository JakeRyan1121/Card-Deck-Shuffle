using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Deck
{  
    public partial class CardDeck : Form
    {
        string[] array = new string[] { "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };
        string[] hand = new string[10];
        int a = 0, intDisCARDed = 0;

        public CardDeck()
        {
            InitializeComponent();
        }

        public void CardDeck_Load(object sender, EventArgs e)
        {
            ListBoxUpdater();
        }

        public void ListBoxUpdater()
        {
            lstbxItems.Items.Clear();
            for (int i = 0; i< 52; i++)
            {
                lstbxItems.Items.Add(array[i]);
            }
        }
        public void btnShuffle_Click(object sender, EventArgs e)
        {
            new Random().Shuffle(array);
            ListBoxUpdater();
        }

        public void btnDrawCard_Click(object sender, EventArgs e)
        {
            string temp = array[0];

            try
            {
                hand[a++] = array[lstbxItems.SelectedIndex];
                array[0] = array[lstbxItems.SelectedIndex];
                array[lstbxItems.SelectedIndex] = temp;
            }
            catch
            {
                if (lstbxItems.SelectedItem == null)
                {
                    MessageBox.Show("Please select a card from the list.");
                }
                else
                {
                    MessageBox.Show("You have already put 10 cards in your hand.");
                    intDisCARDed++;
                    lblDiscarded.Text = intDisCARDed + " Card(s) have been discarded.";
                    
                }
            }
            ListBoxUpdater();
        }
    }
    public static class DoTheShuffle //Randomizer class
    {
        public static void Shuffle<T>(this Random rng, T[] array) //this defines a generic method. This is ideal so that anything
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}