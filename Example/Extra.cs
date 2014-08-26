﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example.Entities;

namespace Example
{
    public partial class Extra : Form
    {
        Person myPerson;
        
        public Extra()
        {
            InitializeComponent();
        }

        public Extra(Person p)
        {
            InitializeComponent();
            myPerson = p;
        }

        private void Extra_Load(object sender, EventArgs e)
        {
            txtBirthPlace.Text = myPerson.Extra.PlaceOfBirth;
            txtBirtDate.Text = myPerson.Extra.DateOfBirth.ToString();
        }

        private void btnSaveExtra_Click(object sender, EventArgs e)
        {
            myPerson.Extra = new AdditionalInformation { PlaceOfBirth = txtBirthPlace.Text, DateOfBirth = Convert.ToDateTime(txtBirtDate.Text) };
            this.Close();
        }

    }
}
