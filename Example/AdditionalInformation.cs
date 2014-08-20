using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Example
{
    public class AdditionalInformation : INotifyPropertyChanged, ICloneable
    {
        private int id;
        private int person_id;
        private DateTime dateOfBirth;
        private string placeOfBirth;

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
                    RaisePropertyChanged(" Person_id");
                }
            }
        }

        public virtual string PlaceOfBirth
        {
            get
            {
                return placeOfBirth;
            }
            set
            {
                if (value != this.placeOfBirth)
                {
                    this.placeOfBirth = value;
                    RaisePropertyChanged("PlaceOfBirth");
                }
            }
        }

        public virtual DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (value != this.dateOfBirth)
                {
                    this.dateOfBirth = value;
                    RaisePropertyChanged("DateOfBirth");
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
            return new AdditionalInformation
            {
                Id = this.id,
                Person_id = this.person_id,
                PlaceOfBirth = this.placeOfBirth,
                DateOfBirth = this.dateOfBirth,
            };
        }

    }
}
