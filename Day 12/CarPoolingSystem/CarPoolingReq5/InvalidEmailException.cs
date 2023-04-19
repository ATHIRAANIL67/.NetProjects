using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingReq5
{
    class InvalidEmailException : Exception
    {
        public InvalidEmailException() : base("InvalidEmailException: Invalid Email for the user") { }
    }
}
