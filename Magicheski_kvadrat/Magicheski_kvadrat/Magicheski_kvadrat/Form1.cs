using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magicheski_kvadrat
{
    public partial class Form1 : Form
    {
        int edno;
        int dve;
        int tri;
        int chetiri;
        int pet;
        int shest;
        int sedem;
        int osem;
        int devet;
        public Form1()
        {
            
            string st = "Трябва да въведете цифра от 1 до 9 в квадратчетата."+"\n";
            st = st+"Целта е :" + "\n";
            st = st + "1.Цифрите да не се повтарят." + "\n";
            st = st + "2.Сумата по всеки ред и всяка колона да е 15." + "\n";
            st = st + "3.Сумата от всички цифри да е 45." + "\n";
            st = st + "УСПЕХ!" + "\n";
            MessageBox.Show(st, "Правила");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edno = int.Parse(textBox1.Text);
            dve = int.Parse(textBox2.Text);
            tri = int.Parse(textBox3.Text);
            chetiri = int.Parse(textBox4.Text);
            pet = int.Parse(textBox5.Text);
            shest = int.Parse(textBox6.Text);
            sedem = int.Parse(textBox7.Text);
            osem = int.Parse(textBox8.Text);
            devet = int.Parse(textBox9.Text);

            if ((edno + dve + tri + chetiri + pet + shest + sedem + osem + devet) < 45) { MessageBox.Show("Има повтарящи се числя", "Грешка");}

           
            label7.Text = ((edno + dve + tri + chetiri + pet + shest + sedem + osem + devet).ToString());
 

            int red1 = edno + dve + tri;
            int red2 = chetiri + pet + shest;
            int red3 = sedem + osem + devet;
            int kolona1 = edno + chetiri + sedem;
            int kolona2 = dve + pet + osem;
            int kolona3 = tri + shest + devet;
            label1.Text = kolona1.ToString();
            label2.Text = kolona2.ToString();
            label3.Text = kolona3.ToString();
            label4.Text = red3.ToString();
            label5.Text = red2.ToString();
            label6.Text = red1.ToString();


            if (red1 == 15 && red2 == 15 && red3 == 15 && kolona1 == 15 && kolona2 == 15 && kolona3 == 15) { MessageBox.Show("Браво, ти успя!", "Честито!"); }
            else MessageBox.Show("Грешка при попълването!", "Грешка");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int edno = int.Parse(textBox1.Text);
                if (edno > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox1.Clear();
                }

                if (edno <1 )
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox1.Clear();
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int dve = int.Parse(textBox2.Text);
                if (dve > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox2.Clear();
                }

                if (dve < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox2.Clear();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int tri = int.Parse(textBox3.Text);
                if (tri > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox3.Clear();
                }

                if (tri < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox3.Clear();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int chetiri = int.Parse(textBox4.Text);
                if (chetiri > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox4.Clear();
                }

                if (chetiri < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox4.Clear();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int pet = int.Parse(textBox5.Text);
                if (pet > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox5.Clear();
                }

                if (pet < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox5.Clear();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int shest = int.Parse(textBox6.Text);
                if (shest > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox6.Clear();
                }

                if (shest < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox6.Clear();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int sedem = int.Parse(textBox7.Text);
                if (sedem > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox7.Clear();
                }

                if (sedem< 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox7.Clear();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int osem = int.Parse(textBox8.Text);
                if (osem > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox8.Clear();
                }

                if (osem < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox8.Clear();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                DialogResult x = DialogResult.OK;
                int devet = int.Parse(textBox9.Text);
                if (devet > 9)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox9.Clear();
                }

                if (devet < 1)
                {
                    x = MessageBox.Show("Моля въведете число от 1 до 9", "Грешка", MessageBoxButtons.OK);
                    if (x == DialogResult.OK) textBox9.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
