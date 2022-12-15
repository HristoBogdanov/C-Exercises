using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabotnik
{
    public partial class Form1 : Form
    {
        List<Rabotnik> rabotnici = new List<Rabotnik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Rabotnik rabotnik = new Rabotnik() ;
            rabotnik.ime = textBox1.Text;
            rabotnik.rabota = textBox2.Text;
            rabotnik.hours = double.Parse(textBox3.Text);
            rabotnik.pari = int.Parse(textBox4.Text);
            rabotnici.Add(rabotnik);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            foreach (Rabotnik x in rabotnici)
                listBox1.Items.Add(x.Print());
        }
    }
}
