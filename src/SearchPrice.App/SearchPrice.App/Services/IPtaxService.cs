using System;
using System.Threading.Tasks;
using Refit;
using SearchPrice.App.Models;

namespace SearchPrice.App.Services
{
    public interface IPtaxService
    {
        [Get("/Moedas")]
        Task<Coins> GetCoinsAsync(int top = 100, int skip = 0, string formart = "json");

        [Get("/CotacaoMoedaDia(moeda=@moeda,dataCotacao=@dataCotacao)")]
        Task<DetailCoins> GetDetailCoinsAsync([Query("", "@")] string moeda, [Query("", "@")] string dataCotacao,
            int top = 100, int skip = 0, string formart = "json");
    }
}