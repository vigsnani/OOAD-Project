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
    public partial class Form8 : Form
    {
        public Form8(string str)
        {
            InitializeComponent();
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);
            EmpID.Text = str;
            cnn.Open();
            string query = "select * from payrollhist where EmployeeID =" + Int32.Parse(EmpID.Text) + ";";
            MySqlCommand user = new MySqlCommand(query, cnn);
            MySqlDataReader sqlreader;
            sqlreader = user.ExecuteReader();
            sqlreader.Read();
            SalaryTXT.Text = sqlreader.GetString("salary");
            FederalTaxTXT.Text = sqlreader.GetString("FederalTax");
            StateTaxTXT.Text = sqlreader.GetString("StateTax");
            FICATXT.Text = sqlreader.GetString("FICA");
            SSNTAXTXT.Text = sqlreader.GetString("SocialSec");
            NetSalaryTXT.Text = sqlreader.GetString("NetSalary");
            cnn.Close();
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
