using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Infrastructure.Db
{
    public class DbEngine
    {
        private readonly IDbConnection _connection;

        public DbEngine(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}
