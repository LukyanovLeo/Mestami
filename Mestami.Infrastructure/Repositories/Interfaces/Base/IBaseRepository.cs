using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Infrastructure.Repositories.Interfaces.Base
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> GetByNameAsync(string name);

        Task<bool> CreateAsync(T entity);

        Task<bool> UpdateByIdAsync(T entity);

        Task<bool> UpdateByNameAsync(T entity);

        Task<bool> DeleteByIdAsync(int id);

        Task<bool> DeleteByNameAsync(string name);
    }
}
