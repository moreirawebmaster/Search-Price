using System.Collections.Generic;
using System.Threading.Tasks;
using SearchPrice.App.Database.Abstracts;
using SearchPrice.App.Models;
using SearchPrice.App.Repositories.Abstracts;

namespace SearchPrice.App.Repositories.Concretes
{
    public class CoinRepository : ICoinRepository
    {
        private readonly IDatabase<CoinModel> _database;

        public CoinRepository(IDatabase<CoinModel> database)
        {
            _database = database;
        }

        public Task<List<CoinModel>> GetCoinsAsync() => _database.GetAllAsync();

        public Task<int> DeleteAsync(int id) => _database.DeleteAsync(id);

        public async Task<bool> InsertAsync(List<CoinModel> values)
        {
            var result = await _database.InsertAsync(values).ConfigureAwait(true);
            return result > 0;
        }

        public async Task<bool> UpdateAsync(CoinModel value)
        {
            var result = await _database.UpdateAsync(value).ConfigureAwait(true);
            return result > 0;
        }
    }
}