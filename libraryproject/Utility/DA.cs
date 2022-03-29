using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace System
{
     public static class DA
    {
         private static SqlConnection _connection = new SqlConnection("Data Source= HC-PC ; Initial Catalog=Library; Integrated Security= true;");

        public static SqlConnection Connection
        {
            get { return DA._connection; }
        }
    }
}
