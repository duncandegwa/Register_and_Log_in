using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Register_and_Log_in
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\RegDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
            Con.Open();
            string query = "insert into studentdetails values('" +REG_NO.Text+ "','" + NAME.Text + "','" + COURSE.Text + "','" + PASSWORD.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You have Registered Successfully!");
            Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           

        }
    }
}
