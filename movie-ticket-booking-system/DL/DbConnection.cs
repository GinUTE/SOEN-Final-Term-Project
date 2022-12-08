using System.Data;
using System.Data.SqlClient;
using movie_ticket_booking_system.Properties;

namespace movie_ticket_booking_system.DL
{
    internal class DbConnection
    {
        private readonly SqlConnection _conn;

        public DbConnection()
        {
            _conn = new SqlConnection(Resources.connStr);
        }

        private SqlConnection OpenConnection()
        {
            if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
                _conn.Open();
            return _conn;
        }

        internal DataTable ExecuteLoadQuery(string query, SqlParameter[] paras = null,
            CommandType cmdType = CommandType.Text)
        {
            try
            {
                using (var cmd = new SqlCommand(query, OpenConnection()))
                {
                    cmd.CommandType = cmdType;
                    if (paras != null)
                        cmd.Parameters.AddRange(paras);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        using (var ds = new DataSet())
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        internal void ExecuteNonQuery(string query, SqlParameter[] paras = null, CommandType cmdType = CommandType.Text)
        {
            try
            {
                using (var cmd = new SqlCommand(query, OpenConnection()))
                {
                    cmd.CommandType = cmdType;
                    if (paras != null)
                        cmd.Parameters.AddRange(paras);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        internal object ExecuteScalar(string query, SqlParameter[] paras = null, CommandType cmdType = CommandType.Text)
        {
            try
            {
                using (var cmd = new SqlCommand(query, OpenConnection()))
                {
                    cmd.CommandType = cmdType;
                    if (paras != null)
                        cmd.Parameters.AddRange(paras);
                    return cmd.ExecuteScalar();
                }
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}