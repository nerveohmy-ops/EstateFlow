using System.Data;
using Microsoft.Data.SqlClient;

namespace EstateFlow.Data
{
    public static class Database
    {
        public static string ConnectionString => AppConfig.Current.ConnectionString;

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static bool TestConnection(out string error)
        {
            try
            {
                using var connection = GetConnection();
                error = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static DataTable GetTable(string sql, params SqlParameter[] parameters)
        {
            using var connection = GetConnection();
            using var command = CreateCommand(connection, sql, parameters);
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using var connection = GetConnection();
            using var command = CreateCommand(connection, sql, parameters);
            return command.ExecuteNonQuery();
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using var connection = GetConnection();
            using var command = CreateCommand(connection, sql, parameters);
            object result = command.ExecuteScalar();
            return result == DBNull.Value ? null : result;
        }

        public static SqlCommand CreateCommand(SqlConnection connection, string sql, params SqlParameter[] parameters)
        {
            var command = new SqlCommand(sql, connection);
            foreach (var p in parameters)
            {
                command.Parameters.Add(new SqlParameter(p.ParameterName, p.Value ?? DBNull.Value));
            }
            return command;
        }

        public static SqlParameter P(string name, object value) => new SqlParameter(name, value ?? DBNull.Value);
    }
}
