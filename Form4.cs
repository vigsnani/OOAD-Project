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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            DataTable datatable = new DataTable();
            string query = "select EmployeeID from personaldata";
            //MySqlCommand user = new MySqlCommand(query, cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(query,cnn);
            sda.Fill(datatable);
            //datatable.Columns.Add("EmployeeID",typeof(String));
            dataGridView1.DataSource = datatable;
        }

        private void Calculate_Payroll_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            this.Hide();
            int[] key = new int[100];
            double[] key1 = new double[10];
            int i = 0;
            int j = 0;
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);

            for (j = 0; j < dataGridView1.Rows.Count; j++)
            {
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[j].Cells[0].Value);
                if (isChecked == true)
                {
                    //MessageBox.Show("Checked");
                    key[i] = Convert.ToInt32(dataGridView1.Rows[j].Cells[1].Value);
                    i++;
                }

            }
            //cnn.Open();

            
           // string query = "select * from personaldata";
           // MySqlCommand user = new MySqlCommand(query, cnn);
            //MySqlDataReader sqlreader;
            //sqlreader = user.ExecuteReader();
           
            //while (sqlreader.Read())
            //{
              //  key[i] = Convert.ToInt32(sqlreader["EmployeeID"]);
               
                //i++;
            //}
            //cnn.Close();

            cnn.Open();
            string query1 = "select * from deductions";
            MySqlCommand user1 = new MySqlCommand(query1, cnn);
            MySqlDataReader sqlreader1;
            sqlreader1 = user1.ExecuteReader();
            int x = 0;
            while (sqlreader1.Read())
            {
                key1[x] = Convert.ToDouble(sqlreader1["DeductionPercent"]);
                x++;
            }
            cnn.Close();

            int index = 0;
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            while (key[index] != 0)
            {
                string query3 = "UPDATE payrollhist SET salary = hoursworked * (SELECT BasicPay FROM jobdata WHERE JobID = (SELECT JobID FROM personaldata WHERE EmployeeID = '" + key[index] + "' )) WHERE EmployeeID ='" + key[index] + "';";
                MySqlCommand update = new MySqlCommand(query3, cnn);
                int numRowsUpdated = update.ExecuteNonQuery();

                string query4 = "UPDATE payrollhist SET FederalTax = salary * (" + key1[0] + ")/100, StateTax = salary * (" + key1[1] + ")/100, FICA = salary * (" + key1[2] + ")/100, SocialSec = salary * (" + key1[3] + ")/100  WHERE EmployeeID ='" + key[index] + "';";
                MySqlCommand update1 = new MySqlCommand(query4, cnn);
                int numRowsUpdated1 = update1.ExecuteNonQuery();

                string query5 = "UPDATE payrollhist SET NetSalary = salary - FederalTax - StateTax - FICA - SocialSec  WHERE EmployeeID ='" + key[index] + "';";
                MySqlCommand update2 = new MySqlCommand(query5, cnn);
                int numRowsUpdated2 = update2.ExecuteNonQuery();
                
                index = index + 1;
            }
            cnn.Close();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            
        }

        private void View_Payslip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
