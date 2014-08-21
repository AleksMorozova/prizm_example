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

namespace Example
{
    public partial class MainForm : Form, IPersonView
    {
        public Dictionary<int, City> personCity;
        public Dictionary<int, Certificate> personCertif;
        public Person myPerson;

        public MainForm()
        {
            InitializeComponent();

            btnLoad.Click += (s,e) => Load(this, e);
            btnSave.Click += (s, e) => Save(this, e);
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
            textEdit1.Text = CertificateListToString(p.Certificates);
            btnSave.Enabled = true;
            btnNew.Enabled = true;
            myPerson = p;
            myPerson.Id = p.Id;
            //IList<int> intL = new List<int>();

            //foreach (Certificate c in p.Certificates)
            //{
            //    foreach (var pair in personCertif)
            //    {
            //        if (pair.Value == c)
            //            intL .Add(pair.Key);

            //        else 
            //        {
            //            intL .Add(13);
            //        }
            //    }
            //}

            //myPerson.Certificates.Count();

            //for (int k = 0; k < myPerson.Certificates.Count; k++)
            //{
            //    listBoxControl1.SetSelected(k, true);
            //    //listBoxControl1.SetSelected(personCertif.FirstOrDefault(x => x.Value == myPerson.Certificates[k]).Key + 1, true);
            //}


        }

        private void btnAutoEdit_Click(object sender, EventArgs e)
        {
            PersonAutomobiles form = new PersonAutomobiles(myPerson);
            form.ShowDialog();

            textEdit2.Text = AutomobilesListToString(myPerson.Automobiles);
            textEdit1.Text = CertificateListToString(myPerson.Certificates);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            myPerson.City = personCity[comboBoxEdit1.SelectedIndex];

            myPerson.Certificates = new List<Certificate>();


            for (int i = 0; i < listBoxControl1.SelectedItems.Count; i++)
            {
                myPerson.Certificates.Add(personCertif[listBoxControl1.SelectedIndices[i]]);
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

        private void btnExtra_Click(object sender, EventArgs e)
        {
            Extra form = new Extra(myPerson);
            form.ShowDialog();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            int i = 0;
            personCity = new Dictionary<int, City>();
            IList<City> allcity = new List<City>();
            var nhConfig = new Configuration().Configure();
            nhConfig.SetProperty(
             "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
             + System.Environment.GetEnvironmentVariable("DATABASE")
             + ";Integrated Security=True;Connect Timeout=30");
            nhConfig.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = nhConfig.BuildSessionFactory();


            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    //repository.BeginTransaction();

                    var city = repository.GetCity();

                    foreach (City c in city)
                    {
                        comboBoxEdit1.Properties.Items.Add(c.Name);
                        personCity.Add(i, c);
                        i++;

                    }
                }
                catch 
                {
                    //repository.RollbackTransaction();
                }
            }



            //using (ISession session = sessionFactory.OpenSession())
            //{
            //    var city = session.CreateCriteria<City>().List<City>();

            //    foreach (City c in city)
            //    {
            //        comboBoxEdit1.Properties.Items.Add(c.Name);
            //        personCity.Add(i, c);
            //        i++;

            //    }
            //}


            int j = 0;
            personCertif = new Dictionary<int, Certificate>();
            IList<Certificate> allcertif = new List<Certificate>();


            using (ISession session = sessionFactory.OpenSession())
            {
                var certificate = session.CreateCriteria<Certificate>().List<Certificate>();


                foreach (Certificate c in certificate)
                {

                    listBoxControl1.Items.Add(c.Name);
                    personCertif.Add(j, c);
                    j++;

                }

                listBoxControl1.SelectedIndex = -1;


                //for (int k = 0; k < listBoxControl1.SelectedItems.Count; k++)
                //{
                //    foreach(Certificate c in myPerson.Certificates)
                //    listBoxControl1.SetSelected(personCertif.FirstOrDefault(x => x.Value == c).Key, true);
                //    //myPerson.Certificates.Add(personCertif[listBoxControl1.SelectedIndices[i]]);
                //}

                //listBoxControl1.SetSelected(4, true);

                // listBoxControl1.SetSelected(6, true);

            }
        }

  
    }
}
