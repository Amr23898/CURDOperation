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
    internal class coursebussinesslayer
    {
        public static DataTable getalldata()
        {
            return DBLyear.selectcomand(new SqlCommand("select * from course"));

        }
        public static int InserData(int id,string name, int duration,int topid)
        {
            SqlCommand query =new SqlCommand("insert into course(crs_id,crs_name,crs_duration,top_id) values(@id,@name,@duration,@topid)");
            query.Parameters.AddWithValue("id", id);
            query.Parameters.AddWithValue("name", name);
            query.Parameters.AddWithValue("duration",duration);
            query.Parameters.AddWithValue("topid", topid);
            int rows= DBLyear.dmlquery(query);
            return rows;
        }
        public static int UpdateData(int id, string name, int duration, int topid)
        {
            SqlCommand query = new SqlCommand("update course set crs_name=@name,crs_duration=@duration,top_id=@topid where crs_id=@id");
            query.Parameters.AddWithValue("id", id);
            query.Parameters.AddWithValue("name", name);
            query.Parameters.AddWithValue("duration", duration);
            query.Parameters.AddWithValue("topid", topid);
            int rows = DBLyear.dmlquery(query);
            return rows;
        }

        public static int DeleteData(int id)
        {
            SqlCommand query = new SqlCommand("delete from course where crs_id=@id");
            query.Parameters.AddWithValue("id", id);
           
            int rows = DBLyear.dmlquery(query);
            return rows;
        }

        public static DataTable search(int id)
        {
            SqlCommand query =new SqlCommand("select * from course where crs_id=@id");
            query.Parameters.AddWithValue("id", id);
            return DBLyear.selectcomand(query);

        }
    }
}
