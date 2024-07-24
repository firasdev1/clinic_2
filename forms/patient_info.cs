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
    public partial class patient_info : Form
    {
        SQLiteCommand cmd;
        SQLiteDataReader rdr;
        public patient_info()
        {
            InitializeComponent();
        }

        private void patient_info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            patient_list.Items.Clear();
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["defaulte"].ConnectionString))
            {
                cnn.Open();

                cmd = new SQLiteCommand("SELECT * FROM patient_info where full_name LIKE @full_name", cnn);
                cmd.Parameters.AddWithValue("full_name", search_tb.Text + "%");

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var item1 = patient_list.Items.Add(rdr[0].ToString());
                    item1.SubItems.Add(rdr[1].ToString());
                    item1.SubItems.Add(rdr[2].ToString());
                    item1.SubItems.Add(rdr[3].ToString());
                    item1.SubItems.Add(rdr[4].ToString());


                }
                cnn.Close();
            }
        }

        private void patient_list_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }

        private void patient_list_Click(object sender, EventArgs e)
        {
            examinations.Items.Clear();
            string patient_id = patient_list.SelectedItems[0].SubItems[0].Text;
            string patient_name = patient_list.SelectedItems[0].SubItems[1].Text;
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
    }
}
