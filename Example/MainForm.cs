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
    public partial class MainForm : Form, IPersonView
    {
        public MainForm()
        {
            InitializeComponent();

            btnLoad.Click += (s,e) => Load(this, e);
            btnSave.Click += (s, e) => Save(this, e);
            this.FormClosed += (s, e) => ViewDispose(this, e);

            new PersonPresenter(this, new PersonRepository());
        }

        public event EventHandler Save = delegate { };
        public event EventHandler Load = delegate { };
        public event EventHandler ViewDispose = delegate { };

        public void ShowValidationError(string text)
        {
            MessageBox.Show(text, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        public void SetPerson(Person p)
        {
           
            bindingSource.DataSource = p;
            bindingSource1.DataSource = p.City;
            //bindingSource2.DataSource = p.ReturnAutomobile;
            btnSave.Enabled = true;
        }

  
    }
}
