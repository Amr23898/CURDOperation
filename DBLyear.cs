using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3layerCrudOperation
{
    public class DBLyear
    {
        public static DataTable selectcomand(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand=cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }


        public static int dmlquery(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            cmd.Connection = con;
            con.Open();
            int row=   cmd.ExecuteNonQuery();
            con.Close(); 
            return row;

        }
    }
}
