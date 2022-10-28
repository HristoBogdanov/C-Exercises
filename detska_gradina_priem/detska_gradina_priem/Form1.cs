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


namespace detska_gradina_priem
{
    public partial class Form1 : Form
    {
        StreamReader reader = new StreamReader("children.txt", Encoding.UTF8);
        StreamWriter writer = new StreamWriter("accepted_children.txt",false,Encoding.UTF8);
        string name,age,adress,nomer,childGardenAdress, hasBrotherOrSister;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Указания за записване на дете :\n 1. Въведете името на детето. \n 2. Въведете годините му с цифра. \n 3. Въведете адреса му. \n 4. Въведете неговия номер. \n 5.Въведете адреса на детската градина, в която искате да бъде записано.\n 6.Напишете с една дума дали детето има брат или сестра в тази детска градина. \n Всяка информация се пише на нов ред ! \n \n Пример: \n Христо Богданов \n 5 \n кв.Левски \n 12 \n кв.Левски \n да \n");
            
        }

        public Form1()
        {   
        InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name = reader.ReadLine();
            age = reader.ReadLine();
            adress = reader.ReadLine();
            nomer = reader.ReadLine();
            childGardenAdress = reader.ReadLine();
            hasBrotherOrSister = reader.ReadLine();
            while(name!=null && age!=null && adress!=null && nomer!=null && childGardenAdress!=null)
            {
                       if(int.Parse(age)>=3 && adress==childGardenAdress && hasBrotherOrSister=="да" && nomer!=null)
                {
                    listBox1.Items.Add(name + " е приет/та!");
                    writer.WriteLine(name);
                    writer.WriteLine(age);
                }
                else listBox1.Items.Add(name + " не е приет/та");
                name = reader.ReadLine();
                age = reader.ReadLine();
                adress = reader.ReadLine();
                nomer = reader.ReadLine();
                childGardenAdress = reader.ReadLine();
                hasBrotherOrSister = reader.ReadLine();
            }
            reader.Close();
            writer.Close();
    }   
    }
}
    
    
    

