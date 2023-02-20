using Mestami.Domain.Aggregates.PlaceAggregate.Place;
using Mestami.Infrastructure.DTO;
using Mestami.Infrastructure.Repositories.Interfaces.Base;
using Mestami.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Infrastructure.Repositories.Interfaces
{
    public interface ILoungeBarRepository : IBaseRepository<LoungeBar>
    {
        Task<IEnumerable<LoungeBar>> GetByFilterAsync(string city, string title, string address, string metroStation);

        Task AddLoungeBar(CreateNewLoungeBarRequest loungeBar);
    }
}
