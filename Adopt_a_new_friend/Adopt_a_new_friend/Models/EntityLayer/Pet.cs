using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_a_new_friend.Models.EntityLayer
{
    class Pet : BasePropertyChanged
    {
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
                NotifyPropertyChanged("ID Pet");
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
                NotifyPropertyChanged("Name of the pet");
            }
        }
        private string bread;
        public string Bread
        {
            get
            {
                return bread;
            }
            set
            {
                bread = value;
                NotifyPropertyChanged("Pet bread");
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                NotifyPropertyChanged("Age of the pet");
            }
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                NotifyPropertyChanged("Pet description");
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
                NotifyPropertyChanged("Pet type");
            }
        }
    }
}
