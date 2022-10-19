using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card
{
    public partial class Form1 : Form
    {
        List <Card> cards = new List <Card>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Name = textBox1.Text;
            card.Autor = textBox2.Text;
            card.Br = int.Parse(textBox3.Text);
            cards.Add(card);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Card x in cards)
            listBox1.Items.Add(x.Print());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string st = textBox4.Text;
            int i = -1;
            do
            {
                i++;
            } while (cards[i].Name != st && i < cards.Count - 1);
            if (i >= cards.Count) label5.Text = "Няма такъв автор";
            else label5.Text = label5.Text + cards[i].Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st = textBox5.Text;
            int i = -1;

                do
                {
                    i++;
                }
                while (cards[i].Name != st && i < cards.Count - 1);
                if (i >= cards.Count) label7.Text = "Няма такава книга";
                else label7.Text = cards[i].Autor;
            
        }
    }
}
