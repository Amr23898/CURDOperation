using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _3layerCrudOperation
{
    internal class topicbussinesslayer
    {
        public static DataTable getalldata()
        {
            return DBLyear.selectcomand(new SqlCommand("select * from topic"));
        }
    }
}
