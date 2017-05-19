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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);


            string query = "select * from payrollhist";
            MySqlCommand command = new MySqlCommand(query, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
