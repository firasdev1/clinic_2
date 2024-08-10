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
    public partial class mainform : Form
    {
        SQLiteCommand cmd;
        private Form activeform;
        private Button currentbtn;
        public mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void patient_info_Click(object sender, EventArgs e)
        {

        }
        private void openchildform(Form childform, object btnsender)
        {
            if (activeform != null) { activeform.Close(); }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childform);
            this.panel4.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbltitel.Text = childform.Text;

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void examinations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new forms.patient_info(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new forms.examination(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentbtn = (Button)sender;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchildform(new forms.addnewpatient(), sender);
        }
    }
}
