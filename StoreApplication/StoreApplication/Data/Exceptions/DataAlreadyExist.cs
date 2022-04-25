using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Data.Exceptions
{
    internal class DataAlreadyExist:Exception
    {
        public DataAlreadyExist(string msg):base(msg)
        {

        }
    }
}
