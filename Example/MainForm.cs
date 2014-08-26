using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example.Entities;
using Example.DB;

namespace Example
{
    public partial class MainForm : Form, IPersonView
    {
        public Dictionary<int, City> personCity;
        public Dictionary<int, Certificate> personCertif;
        public Person myPerson;
        public ItemCache<Certificate> cache;

        public MainForm()
        {
            InitializeComponent();

            btnLoad.Click += (s,e) => Load(this, e);
            btnSave.Click += (s, e) => Update(this, e);
            btnNew.Click += (s, e) => Save(this, e);
            btnDelete.Click += (s, e) => Delete(this, e);
            this.FormClosed += (s, e) => ViewDispose(this, e);

            new PersonPresenter(this, new PersonRepository());
        }

        public event EventHandler Save = delegate { };
        public event EventHandler Load = delegate { };
        public event EventHandler Update = delegate { };
        public event EventHandler Delete = delegate { };
        public event EventHandler ViewDispose = delegate { };

        public void ShowValidationError(string text)
        {
            MessageBox.Show(text, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void SetPerson(Person p)
        {
            bindingSource.DataSource = p;
            bindingSource1.DataSource = p.City;
            textEdit2.Text = AutomobilesListToString(p.Automobiles).ToString();
            btnSave.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnExtra.Enabled = true;
            btnAutoEdit.Enabled = true;
            myPerson = p;
            myPerson.Id = p.Id;

            foreach (Certificate c in p.Certificates)
            {
                listBoxControl1.SetSelected(cache.GetIdGrid(c.Id), true);
            }
        }

        public string AutomobilesListToString(IList<Automobile> auto)
        {
            StringBuilder list = new StringBuilder();
            foreach (Automobile a in auto)
            {
                list.Append(a.Registration_number + ": " + a.Description + "| ");
            }

            return list.ToString();
        }

        public string CertificateListToString(IList<Certificate> certif)
        {
            StringBuilder list = new StringBuilder();
            foreach (Certificate c in certif)
            {
                list.Append(c.Name + "| ");
            }

            return list.ToString(); ;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            personCity = new Dictionary<int, City>();
            IList<City> allcity = new List<City>();
          
            cache = new ItemCache<Certificate>();

            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    var city = repository.GetCity();
                    int i = 0;
                    foreach (City c in city)
                    {

                        comboBoxEdit1.Properties.Items.Add(c.Name);
                        personCity.Add(i, c);
                        i++;
                    }

                    var certificate = repository.GetCertificates();

                    foreach (Certificate c in certificate)
                    {
                        cache.Add(listBoxControl1.Items.Add(c.Name), c.Id, c);
                        
                    }

                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }

            listBoxControl1.SelectedIndex = -1;
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            Extra form = new Extra(myPerson);
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myPerson.City = personCity[comboBoxEdit1.SelectedIndex];

            myPerson.Certificates = new List<Certificate>();

            List<int> selectedItemIndexes = new List<int>();

            foreach (object o in listBoxControl1.SelectedItems)
                selectedItemIndexes.Add(listBoxControl1.Items.IndexOf(o));

            foreach (int index in selectedItemIndexes)
            {
                myPerson.Certificates.Add(cache.GetCertificate(index));
            }
        }

        private void btnAutoEdit_Click(object sender, EventArgs e)
        {
            PersonAutomobiles form = new PersonAutomobiles(myPerson);
            form.ShowDialog();

            textEdit2.Text = AutomobilesListToString(myPerson.Automobiles);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            myPerson.City = personCity[comboBoxEdit1.SelectedIndex];

            myPerson.Certificates = new List<Certificate>();
            IList<Automobile> auto = new List<Automobile>();
            List<int> selectedItemIndexes = new List<int>();

            foreach (object o in listBoxControl1.SelectedItems)
                selectedItemIndexes.Add(listBoxControl1.Items.IndexOf(o));

            foreach (int index in selectedItemIndexes)
            {
                myPerson.Certificates.Add(cache.GetCertificate(index));
            }
            foreach (Automobile a in myPerson.Automobiles)
            {
                auto.Add(new Automobile { Description = a.Description, Registration_number = a.Registration_number });
            }
            myPerson.Automobiles = auto;
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int a = 0;
        }

    }

}

