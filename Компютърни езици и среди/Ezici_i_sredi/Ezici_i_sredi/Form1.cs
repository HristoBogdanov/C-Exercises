using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezici_i_sredi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Формални езици за описание на данни и алгоритми и за тяхната обработка посредством електронноизчислителни машини.Те са част от така наречените 'Формални езици', които са изкуствено създадени езици за професионални цели.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Транслатор в информатиката е компютърна програма, която преобразува програма от един формален компютърен език на друг формален компютърен език.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Когато в един транслатор входният език е от високо ниво (например Ada, C, Java), а изходният – от ниско (машинен език или байт-код), транслаторът се нарича компилатор.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Интерпретаторът е транслатор , който извършва последователен анализ на командите от изходния код, непосредствено ги превежда на машинен език и изпълнява.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свързващият редактор е основна компютърна програма, чиято цел е да свърже компилирани в машинен език един или повече обектни файлове в една програма, която може да се управлява от дадена операционна система. Свързващият редактор е програмна система, която свързва файловете, създадени от компилатора в единен изпълним файл.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Изпълнителната система е част от средата за програмиране , която позволява кода да бъде проверен за грешки и по този начин предотврятява по-нататъчни проблеми с програмата.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Текстовите редактори са компютърни програми, предназначени за редактиране на текстови файлове. Редакторите на обикновен текст са различни от текстовите процесори , защото те могат да показват съдържанието на всеки файл и защото нямат функции на ниво дизайн на съдържанието. Не можете, например, да добавете изображения, рисунки, автоматичен текст и т.н.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Системата за поддръжка на библиотеките е част от средата на програмиране , която минава през кода на проекта , както и през други библиотеки и файлове ,за да изведе данни,методи , класове и свойства.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Системата за помощна информация е свързана с документацията на конкретна среда и при определена клавишна комбинация за помощ извършва различни действия.";
        }
    }
}
