using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SearchPrice.App.Database.Abstracts
{
    public interface IDatabase<T> : IDisposable
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where);
        Task<T> GetByIdAsync(int id);
        Task<int> DeleteAsync(int id);
        Task<int> InsertAsync(T value);
        Task<int> InsertAsync(List<T> values);
        Task<int> UpdateAsync(T value);
    }
}