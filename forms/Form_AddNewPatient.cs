﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_2.forms
{
    public partial class Form_AddNewPatient : Form
    {
        public Form_AddNewPatient()
        {
            InitializeComponent();
        }

        private void btn_Cancel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void AddNewPatientToDateBase()
        {
           //validate form first
           //check if patient is not already present
           //add the patient data to the database
        }

        
    }
}
