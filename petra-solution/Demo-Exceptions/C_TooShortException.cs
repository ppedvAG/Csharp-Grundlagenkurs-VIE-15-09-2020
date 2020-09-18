using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Exceptions
{
    class C_TooShortException : Exception
    {
        public C_TooShortException(string message) : base(message)
        {



        }
    }
}
