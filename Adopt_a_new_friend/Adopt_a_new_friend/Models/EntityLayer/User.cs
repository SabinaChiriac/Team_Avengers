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

        }
       
    }
}
