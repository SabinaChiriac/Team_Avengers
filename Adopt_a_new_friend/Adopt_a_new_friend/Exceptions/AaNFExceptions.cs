﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_a_new_friend.Exceptions
{
    class AaNFExceptions : ApplicationException
    {
        public AaNFExceptions(string message)
            : base(message)
        {
        }
    }
    
}
