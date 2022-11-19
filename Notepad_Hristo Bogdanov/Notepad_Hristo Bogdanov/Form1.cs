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

namespace ContexMenu
{
    public partial class Form1 : Form
    {
        StreamReader fr;
        StreamWriter f;
        string st = "Microsoft Sans Serif";
        int size = 12;
        FontStyle fst = FontStyle.Regular;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void формаНаТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times New Roman", size, fst);
            st = "Times New Roman";
        }

        private void monotypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Monotype Corsiva", size, fst);
            st = "Monotype Corsiva";
        }

        private void големинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 24, fst);
            size = 24;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 14, fst);
            size = 14;
        }

        private void стилToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удебеленToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Bold);
            fst = FontStyle.Bold;
        }

        private void наклоненToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Italic);
            fst = FontStyle.Italic;
        }

        private void подчертанToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Underline);
            fst = FontStyle.Underline;
        }

        private void цветовеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("cvqt.jpg");
        }

        private void фигуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("formi.jpg");
        }

        private void джефБезосToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("bezos.jpg");
        }

        private void маркЗукабъркToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("mark.jpg");
        }

        private void усмивкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("usmivka.jpg");
        }

        private void целувкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("celuvka.jpg");
        }

        private void цвярToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void червенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void зеленToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void синToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void удебеленToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Bold);
            fst = FontStyle.Bold;
        }

        private void наклоненToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Italic);
            fst = FontStyle.Italic;
        }

        private void подчертанToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Underline);
            fst = FontStyle.Underline;
        }

        private void нормаленToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Regular);
            fst = FontStyle.Regular;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                f = new StreamWriter(saveFileDialog1.FileName);
            using (f)
            {
                f.WriteLine(richTextBox1.Text);
            }
            f.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fr = new StreamReader(openFileDialog1.FileName);
                using (fr)
                {
                    string st = fr.ReadLine();
                        while(st!=null)
                    {
                        richTextBox1.Text = richTextBox1.Text + Text + st + "\n";
                        st = fr.ReadLine();
                    }
                    fr.Close();
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Bold);
            fst = FontStyle.Bold;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Italic);
            fst = FontStyle.Italic;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, size, FontStyle.Underline);
            fst = FontStyle.Underline;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void blackToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                f = new StreamWriter(saveFileDialog1.FileName);
            using (f)
            {
                f.WriteLine(richTextBox1.Text);
            }
            f.Close();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fr = new StreamReader(openFileDialog1.FileName);
                using (fr)
                {
                    string st = fr.ReadLine();
                    while (st != null)
                    {
                        richTextBox1.Text = richTextBox1.Text + Text + st + "\n";
                        st = fr.ReadLine();
                    }
                    fr.Close();
                }
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
  
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void blackToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 14, fst);
            size = 14;
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 14, fst);
            size = 14;
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 24, fst);
            size = 24;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 24, fst);
            size = 24;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 28, fst);
            size = 28;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(st, 40, fst);
            size = 40;
        }
    }
}
