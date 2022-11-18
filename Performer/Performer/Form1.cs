using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performer
{
    public partial class Form1 : Form
    {
        Style_Performer n;
        List<Performerr> performers = new List<Performerr>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true) n = Style_Performer.Rock;
            if (radioButton2.Checked == true) n = Style_Performer.Pop;
            if (radioButton3.Checked == true) n = Style_Performer.Opera;
            if (radioButton1.Checked == true) n = Style_Performer.Folklore;
            Performerr performer = new Performerr(textBox1.Text, n, int.Parse(textBox2.Text));
            performers.Add(performer);
            textBox1.Clear();
            textBox2.Clear();
           // radioButton1.Checked = false;
           // radioButton2.Checked = false;
           // radioButton3.Checked = false;
           // radioButton4.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Performerr x in performers)
            {
                if (x.Style == Style_Performer.Rock) comboBox1.Items.Add(x.Name);
            }
        }
    }
}
