using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
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
        private IList<Automobile> automobile;
        private string returnAutomobile;

        public virtual string ReturnAutomobile
        {
            get
            {
                //StringBuilder sb = new StringBuilder();
                //foreach (Automobile auto in automobile)
                //{

                //    sb.Append("1 " + auto.Description + " ");
                //}

                ////returnAutomobile = sb.ToString();
                //returnAutomobile = "!!!";
                return returnAutomobile;
            }
            set
            {
              
                if (value != this.returnAutomobile)
                {
                    this.returnAutomobile = value;
                    RaisePropertyChanged("ReturnAutomobile");
                }
            }

        }

        public virtual IList<Automobile> Automobile
        {
            get
            {
                return automobile;
            }
            set
            {
                if (value != this.automobile)
                {
                    this.automobile = value;
                    RaisePropertyChanged("Automobile");
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
               City=this.city,
               ReturnAutomobile=this.returnAutomobile,
            };
        }
    }
}
