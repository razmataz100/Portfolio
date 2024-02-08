using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1Databasteknik.Repository
{
    public static class Datahandler
    {
        private static string _connString = "Data Source=localhost;Initial Catalog=AdsDatabase;Integrated Security=SSPI;";

        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteReturnTable(string sql, List<SqlParameter> parameters)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            return data;
        }

    }
}