using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_a_new_friend.Models.EntityLayer
{
    class User : BasePropertyChanged
    {
        private int? id_user;
        public int? Id_user
        {
            get
            {
                return id_user;
            }
            set
            {
                id_user = value;
                NotifyPropertyChanged("User ID");
            }

        }
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                NotifyPropertyChanged("User type");
            }

        }
        private string userName;
        public string UserName {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                NotifyPropertyChanged("User name");
            }

        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("User password");
            }
        }
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
                NotifyPropertyChanged("Employee_code/id");
            }
        }

        private int? client_code;
        public int? Client_code
        {
            get
            {
                return client_code;
            }
            set
            {
                client_code = value;
                NotifyPropertyChanged("CLient code/id");
            }
        }



    }
}
