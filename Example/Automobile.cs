using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Automobile
    {
        private string description;
        private int id;
        private int person_id;
        private string registration_number;

        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != this.description)
                {
                    this.description = value;
                    RaisePropertyChanged("Descriptin");
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

        public virtual int Person_id
        {
            get
            {
                return person_id;
            }
            set
            {
                if (value != this.person_id)
                {
                    this.person_id = value;
                    RaisePropertyChanged("Id_automobile");
                }
            }
        }

        public virtual string Registration_number
        {
            get
            {
                return registration_number;
            }
            set
            {
                if (value != this.registration_number)
                {
                    this.registration_number = value;
                    RaisePropertyChanged("Registration_number");
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
            return new Automobile
            {
                Description = this.description,
                Person_id = this.person_id,
                Id = this.id,
                Registration_number = this.registration_number,
            };
        }
    }
}
