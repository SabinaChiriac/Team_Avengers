using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_a_new_friend.Models.EntityLayer
{
    class Order : BasePropertyChanged
    {
        private int? order_id;
        public int? Order_id
        {
            get
            {
                return order_id;
            }
            set
            {
                order_id = value;
                NotifyPropertyChanged("Order_id");
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                NotifyPropertyChanged("Date");
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
                NotifyPropertyChanged("Type");
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
                NotifyPropertyChanged("Client_code");
            }
        }

        private int? id_pet;
        public int? Id_pet
        {
            get
            {
                return id_pet;
            }
            set
            {
                id_pet = value;
                NotifyPropertyChanged("Id_pet");
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
                NotifyPropertyChanged("Employee_code");
            }
        }
    }
}
