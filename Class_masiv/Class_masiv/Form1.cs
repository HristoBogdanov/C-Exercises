using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_masiv
{
    public partial class Form1 : Form
    {
        ComboBox[] marks = new ComboBox[15];
        Label[] subjects = new Label[15];
        string[] names = { "БЕЛ", "Първи ЧЕ", "Втори ЧЕ", "Информатика", "ИТ", "Музика", "Изобразително из-во", "Химия", "Биология", "История", "Философия", "Гражданско образование", "Физика", "Здравна култура", "ФВС" };
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                marks[i] = new ComboBox();
                subjects[i] = new Label();

                subjects[i].Parent = this;
                marks[i].Parent = this;

                marks[i].Width = 100;
                marks[i].Height = 25;

                subjects[i].Top = 30 + (i % 8) * 50;
                subjects[i].Left = (i / 8) * 150 + 50;

                marks[i].Top = subjects[i].Top + 20;
                marks[i].Left = subjects[i].Left;

                subjects[i].Text = names[i];
                subjects[i].AutoSize = true;

                for (int j = 2; j <= 6; j++)
                {
                    marks[i].Items.Add(j);
                }
                if (i == 14) marks[i].Items.Add("освободен");
                marks[i].DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;int num = 14;
            for (int i = 0; i < 14; i++)
            {
                s = s + int.Parse(marks[i].SelectedItem.ToString());
            }
            if (marks[14].Text != "освободен")
            {
                s = s + int.Parse(marks[14].Text);
                num = 15;
            }
            label2.Text = ((double)s / num).ToString("f2");
        }
    }
}
