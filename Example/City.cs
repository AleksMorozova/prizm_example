using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class City : INotifyPropertyChanged, ICloneable
    {
        private string name;
        private int id;
        private int id_city;

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    RaisePropertyChanged("Name");
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

        public virtual int Id_city
        {
            get
            {
                return id_city;
            }
            set
            {
                if (value != this.id_city)
                {
                    this.id_city = value;
                    RaisePropertyChanged("Id_city");
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
            return new City
            {
                Name = this.name,
                Id_city = this.id_city,
                Id = this.id,
            };
        }
    }
}
