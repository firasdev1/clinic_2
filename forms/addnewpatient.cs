using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_2.forms
{
    public partial class addnewpatient : Form
    {
        SQLiteCommand cmd;
        public addnewpatient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["defaulte"].ConnectionString))
            {
                cnn.Open();

                cmd = new SQLiteCommand("INSERT INTO patient_info (full_name,adress,blood_type,age) VALUES ($fullname,$address,$bloodtype,$age)", cnn);
                cmd.Parameters.AddWithValue("fullname", fullname_tb.Text);
                cmd.Parameters.AddWithValue("address", address_tb.Text);
                cmd.Parameters.AddWithValue("bloodtype", bloodtype_tb.Text);
                cmd.Parameters.AddWithValue("age", age_tb.Text);
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
        }
    }
}
