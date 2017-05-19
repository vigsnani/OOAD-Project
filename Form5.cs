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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //private void View_Click(object sender, EventArgs e)
        //{
          //  this.Hide();
            //Form8 f8 = new Form8();
            //f8.ShowDialog();
        //}

        private void View_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
