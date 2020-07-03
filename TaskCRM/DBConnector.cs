using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TaskCRM
{
    public class DBConnector
    {
        private SqlConnection connection;

        public DBConnector() {}

        public void Open(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public bool IsOpen() => connection.State == ConnectionState.Open;

        public void Close() => connection.Close();

        public void ExecuteQuery(string query)
        {
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public DataSet GetDataSet(string query)
        {
            var adapter = new SqlDataAdapter(query, connection);
            var data = new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}
