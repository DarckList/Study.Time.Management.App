using Npgsql;

namespace Study.Time.Management.Data
{
    public class StmDbConnection
    {
        public StmDbConnection(string connectionString)
        {
            Connection = new NpgsqlConnection(connectionString);
        }

        public NpgsqlConnection Connection { get; }
    }
}
