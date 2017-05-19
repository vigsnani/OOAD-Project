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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            //this.Hide();
            int[] key = new int[100];
            //double[] key1 = new double[10];
            int i = 0;
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);

            cnn.Open();


            string query = "select * from jobdata";
            MySqlCommand user = new MySqlCommand(query, cnn);
            MySqlDataReader sqlreader;
            sqlreader = user.ExecuteReader();

            while (sqlreader.Read())
            {
                key[i] = Convert.ToInt32(sqlreader["JobID"]);
                JobID.Items.Add(sqlreader["JobID"]);
                i++;
            }
            cnn.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //int EmployeeID = Convert.ToInt32(IDTB.Text);
            String EmployeeID = IDTB.Text;
            String FirstName = FNameTB.Text;
            String LastName = LNameTB.Text;
            String Gender = GenderTB.Text;
            String DOB = DOBTB.Text;
            String jobid = JobID.Text;
            String EmailID = eMailTB.Text;
            String Phone = PhoneTB.Text;
            String City = CityTB.Text;
            String AddLine1 = AddLine1TB.Text;
            String AddLine2 = AddLine2TB.Text;
            String State = StateTB.Text;
            String Zip = ZipTB.Text;    

            string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";

            string Query = "INSERT INTO personaldata (EmployeeID,FirstName,LastName,Gender,DOB,jobid,EmailID,Phone,City,Address1,Address2,State,Zip) VALUES('" + EmployeeID + "','" + FirstName + "','" + LastName + "','" + Gender + "','" + DOB + "','" + jobid + "','" + EmailID
                + "','" + Phone + "','" + City + "','" + AddLine1 + "','" + AddLine2 + "','" + State + "','" + Zip + "');";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;

            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();
            MyConn2.Close();

            //String employeeID = IDTB.Text;
            int hoursworked = 10;
            

            string MyConnection3 = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";

            string Query1 = "INSERT INTO payrollhist (EmployeeID,hoursworked) VALUES('" + EmployeeID + "','" + hoursworked + "');";

            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);

            MySqlCommand MyCommand3 = new MySqlCommand(Query1, MyConn3);

            MySqlDataReader MyReader3;

            MyConn3.Open();

            MyReader3 = MyCommand3.ExecuteReader();
            MessageBox.Show("Employee Data Saved.");

            MyConn3.Close();

            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
 
                



            //=================================================================

           /* string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=swiftpayroll;pwd='1234'";
            cnn = new MySqlConnection(connectionString);

            cnn.Open();
            string query = "INSERT INTO personaldata (`EmployeeID`, `LastName`, `FirstName`, `Gender`) VALUES ('106', 'N', 'Phaluguna', 'Male');";
            MySqlCommand user = new MySqlCommand(query, cnn);
            MySqlDataReader sqlreader;
            sqlreader = user.ExecuteReader();
            sqlreader.Read();
            IDTB.Text = sqlreader.GetString("EmployeeID");
            FNameTB.Text = sqlreader.GetString("FirstName");
            LNameTB.Text = sqlreader.GetString("LastName");
            GenderTB.Text = sqlreader.GetString("Gender");
            DOBTB.Text = sqlreader.GetString("DOB");
            //JobLevelTB.Text = sqlreader.GetString("JobDesignation");
            eMailTB.Text = sqlreader.GetString("EmailID");
            AddLine1TB.Text = sqlreader.GetString("Address1");
            AddLine2TB.Text = sqlreader.GetString("Address2");
            StateTB.Text = sqlreader.GetString("State");
            ZipTB.Text = sqlreader.GetString("Zip");
            CityTB.Text = sqlreader.GetString("City");*/
        }

        private void Return_Click(object sender, EventArgs e)
        {

        }
    }
}
