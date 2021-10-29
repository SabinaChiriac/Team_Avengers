using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_a_new_friend.Models.EntityLayer
{
    class Address : BasePropertyChanged
    {
        private int? id_address;
        public int? Id_address
        {
            get
            {
                return id_address;
            }
            set
            {
                id_address = value;
                NotifyPropertyChanged("Id_address");
            }
        }

        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                NotifyPropertyChanged("City");
            }
        }

        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
                NotifyPropertyChanged("Street");
            }
        }

        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                NotifyPropertyChanged("Number");
            }
        }
    }
}
