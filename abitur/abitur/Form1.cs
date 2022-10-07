using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abitur
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 28);
            listBox1.Items.Clear();
            switch (x)
            {
                case 1:listBox1.Items.Add("Железният светилник");
                    break;
                case 2:
                    listBox1.Items.Add("Бай Ганьо");
                    break;
                case 3:
                    listBox1.Items.Add("Балкански синдром");
                    break;
                case 4:
                    listBox1.Items.Add("Паисий");
                    break;
                case 5:
                    listBox1.Items.Add("История");
                    break;
                case 6:
                    listBox1.Items.Add("Норв Ковчег");
                    break;
                case 7:
                    listBox1.Items.Add("Борба");
                    break;
                case 8:
                    listBox1.Items.Add("Андрешко");
                    break;
                case 9:
                    listBox1.Items.Add("Приказка за стълбата");
                    break;
                case 10:
                    listBox1.Items.Add("До моето първо либе");
                    break;
                case 11:
                    listBox1.Items.Add("Новото гробище над Сливница");
                    break;
                case 12:
                    listBox1.Items.Add("Крадецът на праскови");
                    break;
                case 13:
                    listBox1.Items.Add("При Рилския манастир");
                    break;
                case 14:
                    listBox1.Items.Add("Градушка");
                    break;
                case 15:
                    listBox1.Items.Add("Спи езерото");
                    break;
                case 16:
                    listBox1.Items.Add("Аз искам да те помня все така");
                    break;
                case 17:
                    listBox1.Items.Add("Колко си хубава!");
                    break;
                case 18:
                    listBox1.Items.Add("Посвещение");
                    break;
                case 19:
                    listBox1.Items.Add("Спасова могила");
                    break;
                case 20:
                    listBox1.Items.Add("Молитва");
                    break;
                case 21:
                    listBox1.Items.Add("Вяра");
                    break;
                case 22:
                    listBox1.Items.Add("Ветрената мелница");
                    break;
                case 23:
                    listBox1.Items.Add("Песента на колелетата");
                    break;
                case 24:
                    listBox1.Items.Add("Балада за Георг Хених");
                    break;
                case 25:
                    listBox1.Items.Add("Две души");
                    break;
                case 26:
                    listBox1.Items.Add("Потомка");
                    break;
                case 27:
                    listBox1.Items.Add("Честен Кръст");
                    break;
            }
        }
    }
}
