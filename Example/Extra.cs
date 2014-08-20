using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bindingSource1.DataSource = myPerson.Extra;
            txtBirtDate.Text = myPerson.Extra.DateOfBirth.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            myPerson.Extra = new AdditionalInformation { PlaceOfBirth = txtBirthPlace.Text, DateOfBirth = Convert.ToDateTime(txtBirtDate.Text), Id = myPerson.Extra.Id, Person_id = myPerson.Extra.Person_id };
        }
    }
}
