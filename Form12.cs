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
    public partial class Form12 : Form
    {
        public Form12(String str)
        {
            InitializeComponent();
           // String JobID = ID.Text;
            //String JobName = Name.Text;
            //String BasicPay = basicpay.Text;

            InitializeComponent();
            ID.Text = str;
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);

            cnn.Open();
            string query = "select * from jobdata where JobID = '" + Int32.Parse(ID.Text) + "'";
            MySqlCommand user = new MySqlCommand(query, cnn);
            MySqlDataReader sqlreader;
            sqlreader = user.ExecuteReader();
            sqlreader.Read();
            ID.Text = sqlreader.GetString("JobID");
            DesName.Text = sqlreader.GetString("JobName");
            basicpay.Text = sqlreader.GetString("BasicPay");
        }

        private void Form12_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
