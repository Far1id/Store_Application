using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Data.Exceptions
{
    internal class DataNotExist:Exception
    {
        public DataNotExist(string msg) : base(msg)
        {

        }
    }
}
