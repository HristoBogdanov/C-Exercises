using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pazaruvane
{
 
    public partial class Form1 : Form
    {
        StreamReader reader = new StreamReader("list.txt", Encoding.UTF8);
        string pom;
        List<string> zapisi = new List<string>();
        List<string> pom_list = new List<string>();
        List<Product> products = new List<Product>();
        double kraina_cena=0;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pom = reader.ReadLine();
            do
            {
                zapisi.Add(pom);
                pom = reader.ReadLine();
            } while (pom != null);

            foreach (string x in zapisi)
            {
                var result = x.Split(' ');
                    foreach(var p in result)
                {
                    pom_list.Add(p);
                }
            }
            for (int i = 0; i < pom_list.Count;i=i+3)
            {   
                comboBox1.Items.Add(pom_list[i]);
                Product product = new Product(pom_list[i], double.Parse(pom_list[i + 1]), double.Parse(pom_list[i + 1]));
                products.Add(product);
            }
            MessageBox.Show("Продуктите бяха заредени успешно! Моля преминете към пазаруване в следващия прозорец.");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Вашата поръчка беше обработена успешно!");
            listBox1.Items.Add($"Обща сума: {kraina_cena}лв.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ammount_wanted = int.Parse(textBox1.Text);
            string l = comboBox1.Text;

            switch (l)
            {
                case "Cheese":
                    if (ammount_wanted <= products[0].Ammount)
                    {
                        listBox1.Items.Add($"{products[0].Name} -- {ammount_wanted} -- {ammount_wanted * products[0].Price}лв.");
                        kraina_cena += ammount_wanted * products[0].Price;
                        products[0].Ammount = products[0].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[0].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;

                case "Sausage":
                    if (ammount_wanted <= products[1].Ammount)
                    {
                        listBox1.Items.Add($"{products[1].Name} -- {ammount_wanted} -- {ammount_wanted * products[1].Price}лв.");
                        kraina_cena += ammount_wanted * products[1].Price;
                        products[1].Ammount = products[1].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[1].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;

                case "Veal":
                    if (ammount_wanted <= products[2].Ammount)
                    {
                        listBox1.Items.Add($"{products[2].Name} -- {ammount_wanted} -- {ammount_wanted * products[2].Price}лв.");
                        kraina_cena += ammount_wanted * products[2].Price;
                        products[2].Ammount = products[2].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[2].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;

                case "Chicken":
                    if (ammount_wanted <= products[3].Ammount)
                    {
                        listBox1.Items.Add($"{products[3].Name} -- {ammount_wanted} -- {ammount_wanted * products[3].Price}лв.");
                        kraina_cena += ammount_wanted * products[3].Price;
                        products[3].Ammount = products[3].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[3].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;

                case "Pork":
                    if (ammount_wanted <= products[4].Ammount)
                    {
                        listBox1.Items.Add($"{products[4].Name} -- {ammount_wanted} -- {ammount_wanted * products[4].Price}лв.");
                        kraina_cena += ammount_wanted * products[4].Price;
                        products[4].Ammount = products[4].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[4].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;

                case "Flour":
                    if (ammount_wanted <= products[5].Ammount)
                    {
                        listBox1.Items.Add($"{products[5].Name} -- {ammount_wanted} -- {ammount_wanted * products[5].Price}лв.");
                        kraina_cena += ammount_wanted * products[5].Price;
                        products[5].Ammount = products[5].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[5].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;

                case "Sugar":
                    if (ammount_wanted <= products[6].Ammount)
                    {
                        listBox1.Items.Add($"{products[6].Name} -- {ammount_wanted} -- {ammount_wanted * products[6].Price}лв.");
                        kraina_cena += ammount_wanted * products[6].Price;
                        products[6].Ammount = products[6].Ammount - ammount_wanted;
                    }
                    else MessageBox.Show($"Няма достатъчно количество от този продукт. Наличното количество е {products[6].Ammount}бр.");
                    comboBox1.Text = "";
                    textBox1.Clear();
                    break;
            }
                

        }
    }
}
