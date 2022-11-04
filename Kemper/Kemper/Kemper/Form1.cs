using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kemper
{
    public partial class Form1 : Form
    {
        List<Kemper> kemperi = new List<Kemper>();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kemper kemper = new Kemper(textBox1.Text, comboBox1.Text, int.Parse(textBox2.Text));
            if (kemperi.Any(x => x.Ime == kemper.Ime && x.Mqsto == kemper.Mqsto))
            {
                kemperi.Find(x => x.Ime == kemper.Ime && x.Mqsto == kemper.Mqsto).Dni += kemper.Dni;
            }
            else kemperi.Add(kemper);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            kemperi = kemperi.OrderByDescending(x => x.Dni).ThenBy(x => x.Ime).ToList();
            foreach (Kemper x in kemperi)
                listBox1.Items.Add(x.Print());
        }
    }
}
