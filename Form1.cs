using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_2
{
    public partial class Form1 : Form
    {
        SQLiteCommand cmd;
        SQLiteDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void patient_info_Click(object sender, EventArgs e)
        {
            examinations.Items.Clear();
            string patient_id = patient_info.SelectedItems[0].SubItems[0].Text;
            string patient_name = patient_info.SelectedItems[0].SubItems[1].Text;
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["defaulte"].ConnectionString))
            {
                cnn.Open();
               
                cmd = new SQLiteCommand("SELECT * FROM examinations where patient_id = @id", cnn);
                cmd.Parameters.AddWithValue("id", patient_id);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var item1 = examinations.Items.Add(rdr[0].ToString());
                    item1.SubItems.Add(rdr[1].ToString());
                    item1.SubItems.Add(rdr[2].ToString());

                }
                cnn.Close();

            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            patient_info.Items.Clear();
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["defaulte"].ConnectionString))
            {
                cnn.Open();
                
                cmd = new SQLiteCommand("SELECT * FROM patient_info where full_name LIKE @full_name", cnn);
                cmd.Parameters.AddWithValue("full_name", search_tb.Text+"%");

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var item1 = patient_info.Items.Add(rdr[0].ToString());
                    item1.SubItems.Add(rdr[1].ToString());
                    item1.SubItems.Add(rdr[2].ToString());
                    item1.SubItems.Add(rdr[3].ToString());
                    item1.SubItems.Add(rdr[4].ToString());
                 

                }
                cnn.Close();







            }
        }
    }
}
