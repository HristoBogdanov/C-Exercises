using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masivi_gymnastika
{
    public partial class Form1 : Form
    {
        ComboBox[] marks = new ComboBox[10];
        Label[] judges = new Label[7];
        string[] names = { "Съдия 1", "Съдия 2", "Съдия 3", "Съдия 4", "Съдия 5" };
        Participants participant = new Participants();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                
                marks[i] = new ComboBox();
                judges[i] = new Label();

                marks[i].Parent = this;
                judges[i].Parent = this;

                marks[i].Height = 100;
                marks[i].Width = 25;

                judges[i].Top = 30 + (i%1 ) * 50;
                judges[i].Left = (i/1 ) * 150 + 50;

                marks[i].Top = judges[i].Top + 20;
                marks[i].Left = judges[i].Left;
               
                judges[i].Text = names[i];
                judges[i].AutoSize = true;

                for (int j = 1; j <= 10; j++)
                {
                     marks[i].Items.Add(j); 
                }
                marks[i].DropDownStyle = ComboBoxStyle.DropDownList;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
