using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drob
{
    public partial class Form1 : Form
    {
        Drob drob1 = new Drob();
        char znak;
        public Form1()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            znak = '+';
            listBox1.Items.Clear();           
            drob1.Chislitel = int.Parse(textBox1.Text);
            drob1.Znamenatel = int.Parse(textBox2.Text);
            drob1.Chislitel = drob1.Chislitel / drob1.Deliteli(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            drob1.Znamenatel = drob1.Znamenatel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add(drob1.Chislitel);
            listBox1.Items.Add("━");
            listBox1.Items.Add(drob1.Znamenatel);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Add("+");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            znak = '*';
            drob1.Chislitel = int.Parse(textBox1.Text);
            drob1.Znamenatel = int.Parse(textBox2.Text);
            drob1.Chislitel = drob1.Chislitel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            drob1.Znamenatel = drob1.Znamenatel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Add(drob1.Chislitel);
            listBox1.Items.Add("━");
            listBox1.Items.Add(drob1.Znamenatel);
            listBox1.Items.Add("*");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            znak = '-';            
            drob1.Chislitel = int.Parse(textBox1.Text);
            drob1.Znamenatel = int.Parse(textBox2.Text);
            drob1.Chislitel = drob1.Chislitel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            drob1.Znamenatel = drob1.Znamenatel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add(drob1.Chislitel);
            listBox1.Items.Add("━");
            listBox1.Items.Add(drob1.Znamenatel);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Add("-");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            znak = '/';
            drob1.Chislitel = int.Parse(textBox1.Text);
            drob1.Znamenatel = int.Parse(textBox2.Text);
            drob1.Chislitel = drob1.Chislitel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            drob1.Znamenatel = drob1.Znamenatel / drob1.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add(drob1.Chislitel);
            listBox1.Items.Add("━");
            listBox1.Items.Add(drob1.Znamenatel);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Add("/");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Drob drob2 = new Drob();
            drob2.Chislitel = int.Parse(textBox1.Text);
            drob2.Znamenatel = int.Parse(textBox2.Text);
            drob2.Chislitel = drob2.Chislitel / drob2.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            drob2.Znamenatel = drob2.Znamenatel / drob2.Deliteli(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            listBox1.Items.Clear();
            int rezultat_na_chislitel;
            int rezultat_na_znamenatel;

            switch (znak) {
                case '+':
                    rezultat_na_chislitel = (drob1.Chislitel*drob2.Znamenatel) + (drob1.Znamenatel * drob2.Chislitel);
                    rezultat_na_znamenatel = drob1.Znamenatel * drob2.Znamenatel;
                    drob1.Znamenatel = rezultat_na_znamenatel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    drob1.Chislitel = rezultat_na_chislitel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);                   
                    if (drob1.Chislitel == drob1.Znamenatel) listBox1.Items.Add("1");
                    else if (drob1.Chislitel == -drob1.Znamenatel || drob1.Znamenatel == -drob1.Chislitel) listBox1.Items.Add("-1");
                    else if (drob1.Chislitel == 0) listBox1.Items.Add("0");
                    else
                    {
                        listBox1.Items.Add(drob1.Chislitel);
                        listBox1.Items.Add("━");
                        listBox1.Items.Add(drob1.Znamenatel);
                    }
                    break;
                case '-':             
                    rezultat_na_chislitel = (drob1.Chislitel * drob2.Znamenatel) - (drob1.Znamenatel * drob2.Chislitel);
                    rezultat_na_znamenatel = drob1.Znamenatel * drob2.Znamenatel;
                    drob1.Znamenatel = rezultat_na_znamenatel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    drob1.Chislitel = rezultat_na_chislitel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    if (drob1.Chislitel == drob1.Znamenatel) listBox1.Items.Add("1");
                    else if (drob1.Chislitel == -drob1.Znamenatel || drob1.Znamenatel == -drob1.Chislitel) listBox1.Items.Add("-1");
                    else if (drob1.Chislitel == 0) listBox1.Items.Add("0");
                    else
                    {
                        listBox1.Items.Add(drob1.Chislitel);
                        listBox1.Items.Add("━");
                        listBox1.Items.Add(drob1.Znamenatel);
                    }
                    break;
                case '*':
                    rezultat_na_chislitel = drob1.Chislitel * drob2.Chislitel;
                    rezultat_na_znamenatel = drob1.Znamenatel * drob2.Znamenatel;
                    drob1.Znamenatel = rezultat_na_znamenatel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    drob1.Chislitel = rezultat_na_chislitel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    if (drob1.Chislitel == drob1.Znamenatel) listBox1.Items.Add("1");
                    else if (drob1.Chislitel == -drob1.Znamenatel || drob1.Znamenatel == -drob1.Chislitel) listBox1.Items.Add("-1");
                    else if (drob1.Chislitel == 0) listBox1.Items.Add("0");
                    else
                    {
                        listBox1.Items.Add(drob1.Chislitel);
                        listBox1.Items.Add("━");
                        listBox1.Items.Add(drob1.Znamenatel);
                    }
                    break;
                case '/':
                    rezultat_na_chislitel = drob1.Chislitel * drob2.Znamenatel;
                    rezultat_na_znamenatel = drob1.Znamenatel * drob2.Chislitel;
                    drob1.Znamenatel = rezultat_na_znamenatel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    drob1.Chislitel = rezultat_na_chislitel / drob1.Deliteli(rezultat_na_chislitel, rezultat_na_znamenatel);
                    if (drob1.Chislitel == drob1.Znamenatel) listBox1.Items.Add("1");
                    else if (drob1.Chislitel == -drob1.Znamenatel || drob1.Znamenatel == -drob1.Chislitel) listBox1.Items.Add("-1");
                    else
                    {
                        listBox1.Items.Add(drob1.Chislitel);
                        listBox1.Items.Add("━");
                        listBox1.Items.Add(drob1.Znamenatel);
                    }
                    break;

            }




        }
    }
}
