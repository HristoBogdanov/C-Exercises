using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planini
{
    public partial class Form1 : Form
    {
        List<Vruh> vurhove = new List<Vruh>();
        List<Reka> reki = new List<Reka>();
        List<Planina> planini = new List<Planina>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Planina planina = new Planina(textBox1.Text, textBox2.Text);
            Vruh vruh = new Vruh(textBox4.Text, int.Parse(textBox5.Text) ,(textBox3.Text) ,textBox1.Text,textBox2.Text);
            Reka reka = new Reka(textBox8.Text, textBox7.Text, int.Parse(textBox6.Text), textBox1.Text, textBox2.Text);
            vurhove.Add(vruh);
            reki.Add(reka);
            planini.Add(planina);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            string st = textBox9.Text;
            for (int i = 0; i <= planini.Count - 1; i++)
            {
                if (st == planini[i].strana) listBox1.Items.Add(planini[i].ime);
                else listBox1.Items.Add("Няма въведени планини");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string st = textBox10.Text;
            for (int i = 0; i <= vurhove.Count - 1; i++)
            {
                if (st == vurhove[i].Ime_planina) listBox1.Items.Add(vurhove[i].ime);
                else listBox1.Items.Add("Няма въведени върхове");
            }
            listBox1.Items.Clear();
            for (int i = 0; i <= reki.Count - 1; i++)
            {
                if (st == reki[i].Ime_planina) listBox1.Items.Add(reki[i].ime);
                else listBox1.Items.Add("Няма въведени реки");
            }
        }
    }
}
