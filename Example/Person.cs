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

        public string FirstName 
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

        public string LastName 
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

        public int Age 
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

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return new Person
            {
               FirstName = this.firstName,
               LastName = this.lastName,
               Age = this.age,
            };
        }
    }
}
