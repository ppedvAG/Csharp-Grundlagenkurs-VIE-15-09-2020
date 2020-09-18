using System;
using System.Collections.Generic;
using System.Text;

namespace D_M12_Exceptions
{
    class TooShortException : Exception
    {
        public TooShortException(string message) : base(message)
        {
        }
    }
}
