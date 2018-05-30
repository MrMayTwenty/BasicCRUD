using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BasicCRUD.Controller
{
    class DatabaseController
    {

        private static String Connection = Properties.Settings.Default.ConnectionString;
        private static String Server = Properties.Settings.Default.Server;
        private static String Database = Properties.Settings.Default.Database;
        private String ConnectionString = String.Format(Connection, Server, Database);

        /// <summary>
        /// Retrieve a table from the query
        /// </summary>
        /// <param name="sql">SQL Query</param>
        /// <returns></returns>
        public DataTable GetTable(string sql) {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection()) {
                try
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Dispose();
                }
                catch (Exception ex)
                {

                }
               
            }
            return dt;
        }

        /// <summary>
        /// Save or Update Data
        /// </summary>
        /// <param name="sql">Sql Query</param>
        public void ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            }
        }

       
    }
}
