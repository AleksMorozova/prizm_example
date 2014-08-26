using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Entities
{
    /// <summary>
    /// DOMAIN MODEL CLASS (will be mapped with Hibernate)
    /// </summary>
    public class Person : INotifyPropertyChanged, ICloneable
    {
        private string firstName;
        private string lastName;
        private int age;
        private int id;
        private City city;

        private AdditionalInformation extra;
        private IList<Automobile> automobiles;
        private IList<Automobile> personAutomobiles;

        private IList<Certificate> certificates;

        public virtual IList<Automobile> PersonAutomobiles
        {
            get
            {
                return personAutomobiles;
            }
            set
            {
                if (value != this.personAutomobiles)
                {
                    this.personAutomobiles = value;
                    RaisePropertyChanged("PersonAutomobiles");
                }
            }
        }

        public virtual AdditionalInformation Extra
        {
            get
            {
                return extra;
            }
            set
            {
                if (value != this.extra)
                {
                    this.extra = value;
                    RaisePropertyChanged("PersonAutomobiles");
                }
            }
        }

        public virtual IList<Automobile> Automobiles
        {
            get
            {
                return automobiles;
            }
            set
            {
                if (value != this.automobiles)
                {
                    this.automobiles = value;
                    RaisePropertyChanged("Automobile");
                }
            }
        }

        public virtual IList<Certificate> Certificates
        {
            get
            {
                return certificates;
            }
            set
            {
                if (value != this.certificates)
                {
                    this.certificates = value;
                    RaisePropertyChanged("Certificates");
                }
            }
        }

        public virtual string FirstName 
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }

        }

        public virtual string LastName 
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }

        public virtual int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value != this.age)
                {
                    this.age = value;
                    RaisePropertyChanged("Age");
                }
            }
        }

        public virtual int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        public virtual City City
        {
            get
            {
                return city;
            }
            set
            {
                if (value != this.city)
                {
                    this.city = value;
                    RaisePropertyChanged("City");
                }
            }
        }

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual object Clone()
        {
            return new Person
            {
                FirstName = this.firstName,
                LastName = this.lastName,
                Age = this.age,
                City = this.city,
                Automobiles = this.automobiles,
                Certificates = this.certificates,
                Extra = this.extra,
            };
        }
    }
}
