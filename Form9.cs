using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SwiftPayRoll
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            this.Hide();
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            MySqlConnection cnn = new MySqlConnection(connectionString);;
            //MySqlCommand command = new MySqlCommand();
            //cnn.Open();
            string query = "select * from personaldata";
            MySqlCommand command = new MySqlCommand(query, cnn);
            DataTable data = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;
             
        }
    }
}
