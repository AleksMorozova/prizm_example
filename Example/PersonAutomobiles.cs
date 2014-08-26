using System;
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
    public partial class PersonAutomobiles : Form//, IAutomobileView
    {
        Person myPerson;

        public PersonAutomobiles()
        {
            InitializeComponent();
        }

        public PersonAutomobiles(Person p)
        {
            InitializeComponent();
            myPerson = p;
        }

        private void PersonAutomobiles_Load(object sender, EventArgs e)
        {
            Automobiles.DataSource = myPerson.Automobiles;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {  
            this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            Automobiles.RefreshDataSource();
            //myPerson.Automobiles.RemoveAt();
            int l = 0;
        }

        private void btnAutoEdit_Click(object sender, EventArgs e)
        {
            Automobiles.RefreshDataSource();
            MainForm form = new MainForm();
            form.myPerson = myPerson;
            this.Close();
        }

        private void btnaddcar_Click(object sender, EventArgs e)
        {
            Automobile auto = new Automobile { Description = descriptiontxtEdit.Text, Registration_number = registrnumbtxtEdit.Text, Person_id=this.myPerson.Id};
            myPerson.Automobiles.Add(auto);
            Automobiles.RefreshDataSource();
        }

    }
}
