using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_vs_connection_SQL
{
    public partial class Form1 : Form
    {
        static string connectionstring = "Data Source=DESKTOP-NUE864C\\SQLEXPRESS;Initial Catalog=Primer_connection;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionstring);
        string querySelect = "SELECT ID,ime,telefon FROM Clients";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                SqlCommand command1 = new SqlCommand(querySelect, connection);
                connection.Open();
                SqlDataReader reader = command1.ExecuteReader();

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
