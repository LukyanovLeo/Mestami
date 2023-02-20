using System.Data;
using Mestami.Infrastructure.Repositories.Infra.Interfaces;
using Microsoft.Extensions.Options;
using Npgsql;

namespace Mestami.Infrastructure.Repositories.Infra
{
    public class NpgsqlConnectionFactory : IDbConnectionFactory<NpgsqlConnection>
    {
        private readonly DbConnectionOptions _options;
        private NpgsqlConnection _connection;

        public NpgsqlConnectionFactory(DbConnectionOptions options)
        {
            _options = options;
        }

        public async Task<NpgsqlConnection> CreateConnection(CancellationToken token)
        {
            if (_connection != null) return _connection;

            _connection = new NpgsqlConnection(_options.ConnectionString);
            await _connection.OpenAsync(token);
            _connection.StateChange += (o, e) =>
            {
                if (e.CurrentState == ConnectionState.Closed) _connection = null;
            };
            return _connection;
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}