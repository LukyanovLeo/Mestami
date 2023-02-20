namespace Mestami.Infrastructure.Repositories.Infra
{
    public class DbConnectionOptions
    {
        public DbConnectionOptions(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
    }
}
