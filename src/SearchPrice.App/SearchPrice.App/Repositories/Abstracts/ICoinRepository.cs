using System.Collections.Generic;
using System.Threading.Tasks;
using SearchPrice.App.Models;

namespace SearchPrice.App.Repositories.Abstracts
{
    public interface ICoinRepository
    {
        Task<List<CoinModel>> GetCoinsAsync();
        Task<int> DeleteAsync(int id);
        Task<bool> InsertAsync(List<CoinModel> values);
        Task<bool> UpdateAsync(CoinModel value);
    }
}