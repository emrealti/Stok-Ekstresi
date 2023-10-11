using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     class SqlBaglantisi
    {
        public SqlConnection connection()
        {
            {
                SqlConnection connet = new SqlConnection(@"Data Source=DESKTOP-URKG832\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
                connet.Open();
                return connet;
            }
        }
    }
}
