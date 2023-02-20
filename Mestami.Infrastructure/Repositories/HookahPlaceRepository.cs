using Dapper;
using Mestami.Domain.Geo;
using Mestami.Domain.Models.Geo;
using Mestami.Infrastructure.DTO;
using Mestami.Infrastructure.Repositories.Infra.Interfaces;
using Mestami.Infrastructure.Repositories.Interfaces;
using Mestami.Infrastructure.Repositories.Queries;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;
using Mestami.Domain.Aggregates.PlaceAggregate.Place;
using System.Net;
using Mestami.Infrastructure.Requests;

namespace Mestami.Infrastructure.Repositories
{
    public class LoungeBarRepository : ILoungeBarRepository
    {
        private readonly IDbConnectionFactory<NpgsqlConnection> _dbConnectionFactory;

        public LoungeBarRepository(IDbConnectionFactory<NpgsqlConnection> dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<IEnumerable<LoungeBar>> GetAllAsync()
        {
            var connection = await _dbConnectionFactory.CreateConnection();
            var loungeBars = await connection.QueryAsync<LoungeBar>(LoungeBarQueries.GetAll);

            return loungeBars;
        }

        public async Task<IEnumerable<LoungeBar>> GetByFilterAsync(string city, string title, string address, string metroStation)
        {
            var dp = new DynamicParameters();
            dp.Add("@city", city ?? "", DbType.String);
            dp.Add("@title", title ?? "", DbType.String);
            dp.Add("@address", address ?? "", DbType.String);
            dp.Add("@metroStation", metroStation ?? "", DbType.String);

            var connection = await _dbConnectionFactory.CreateConnection();
            var loungeBars = await connection.QueryAsync<LoungeBar>(LoungeBarQueries.GetByFilter, dp);

            return loungeBars;
        }

        public async Task AddLoungeBar(CreateNewLoungeBarRequest loungeBar)
        {
            //var dp = new DynamicParameters();
            //dp.Add("@address", entity.Address, DbType.String);
            //dp.Add("@cityId", 1, DbType.String);
            //dp.Add("@metro_stations_id", entity.metro, DbType.String);
            //dp.Add("@is_vip_room", city ?? "", DbType.String);
            //dp.Add("@vip_room_pricing", city ?? "", DbType.String);
            //dp.Add("@pros", title ?? "", DbType.String);
            //dp.Add("@cons", address ?? "", DbType.String);
            //dp.Add("@title", metroStation ?? "", DbType.String);

            var connection = await _dbConnectionFactory.CreateConnection();
            var loungeBars = await connection.QueryAsync<LoungeBar>(LoungeBarQueries.GetByFilter);
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<LoungeBar> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LoungeBar> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateByIdAsync(LoungeBar entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateByNameAsync(LoungeBar entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(LoungeBar entity)
        {
            throw new NotImplementedException();
        }
    }
}
