using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            int y = int.Parse(textBox2.Text);
            int p = int.Parse(textBox3.Text);
            int v = int.Parse(textBox4.Text);
            string t = textBox5.Text;
            double w = double.Parse(textBox6.Text);
            Car car = new Car(ime, y, p, v, t, w);
            cars.Add(car);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Car x in cars)
                listBox1.Items.Add(x.Print());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t_t = textBox7.Text;
            for(int i=0;i<cars.Count-1;i++)
                if (t_t==cars[i].Get_Name_Cargo())
                    listBox2.Items.Add(cars[i].Get_Name_Car()+ "-" + cars[i].Get_Weight());
        }
    }
}
