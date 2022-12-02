using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_vs_connection_Access
{
   
    public partial class Form1 : Form
    {
        static string connectionstring = "primeren_conection_string";
        OleDbConnection connection = new OleDbConnection(connectionstring);
        string queryString = "SELECT ID,ime,telefon FROM Clients";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                OleDbCommand command1 = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command1.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add($"{reader[0]} -- {reader[1]} -- {reader[2]}");
                    }
                }
            }
        }
    }
}
