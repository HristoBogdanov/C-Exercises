using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archery
{
    public partial class Form1 : Form
    {
        StreamReader reader = new StreamReader("input.txt", Encoding.UTF8); 
        StreamWriter writer = new StreamWriter("output.txt", false, Encoding.UTF8);
        string name;
        string club;
        string city;
        int max = 0;

        Player winner = new Player("pom",1);
        List<Player> players = new List<Player>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = reader.ReadLine();
            club = reader.ReadLine();
            city = reader.ReadLine();
            while (name != null)
            {
                comboBox1.Items.Add(name);
                name = reader.ReadLine();
                club = reader.ReadLine();
                city = reader.ReadLine();
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int strelba1 = int.Parse(textBox1.Text);
            int strelba2 = int.Parse(textBox2.Text);
            int strelba3 = int.Parse(textBox3.Text);
            int strelba4 = int.Parse(textBox4.Text);
            int strelba5 = int.Parse(textBox5.Text);
            max = strelba1;
            if (strelba2 > max) max = strelba2;
            if(strelba3>max)max = strelba3;
            if (strelba4 > max) max = strelba4;
            if (strelba5 > max) max = strelba5;
            if (strelba1 % 10 != 0 || strelba2 % 10 != 0 || strelba3 % 10 != 0 || strelba4 % 10 != 0 || strelba5 % 10 != 0)
                MessageBox.Show("Можете да въвеждате само точки , които се делят на десет (10,20,50 и т.н.)!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            Player player = new Player(comboBox1.Text, max);
            Player winner = new Player(comboBox1.Text, max);
            players.Add(player);

            
    }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Player> winners = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Result > winner.Result) winner = players[i];
            }
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Result == winner.Result)
                {
                    winners.Add(players[i]);
                }
            }
            richTextBox1.Text = "Победител/и е/са :";
                for (int i = 0; i < winners.Count; i++)
                {
                richTextBox1.Text = richTextBox1.Text + "\n" + winners[i].Name + "--" + winners[i].Result + " точки";
                writer.WriteLine(winners[i].Name);
                writer.WriteLine(winners[i].Result);
                }
            writer.Close();
        }
    }
}
   
