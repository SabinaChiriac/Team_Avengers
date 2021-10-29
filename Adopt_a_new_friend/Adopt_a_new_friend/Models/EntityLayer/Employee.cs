using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_a_new_friend.Models.EntityLayer
{
    class Employee : BasePropertyChanged
    {
        private int? employee_code;
        public int? Employee_code
        {
            get
            {
                return employee_code;
            }
            set
            {
                employee_code = value;
                NotifyPropertyChanged("Employee_code");
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string phone;
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                NotifyPropertyChanged("Phone");
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }

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
    }
}
