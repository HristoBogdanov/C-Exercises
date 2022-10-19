using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Building_firm
{
    public partial class Form1 : Form
    {
        List<double> area =new List<double>();
        double sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
               area.Add(int.Parse(Interaction.InputBox("Въведи размер на стая")));
            }
            
            for (int i = 0; i < area.Count; i++)
            {
                sum = sum + area[i];
            }
            double Paint_needed = sum / 8;
            listBox1.Items.Add("Ще бъдат неубходими: " + Paint_needed + " литра боя");
        }
    }
}
