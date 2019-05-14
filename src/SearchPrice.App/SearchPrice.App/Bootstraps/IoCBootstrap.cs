using Refit;
using SearchPrice.App.Database.Abstracts;
using SearchPrice.App.Database.Concretes;
using SearchPrice.App.Models;
using SearchPrice.App.Repositories.Abstracts;
using SearchPrice.App.Repositories.Concretes;
using SearchPrice.App.Services;
using static FreshMvvm.FreshIOC;

namespace SearchPrice.App.Bootstraps
{
    public class IoCBootstrap
    {
        public static void Init()
        {
            Container.Register(RestService.For<IPtaxService>(Constants.URL));
            Container.Register<IDatabase<CoinModel>, DatabaseSQLite<CoinModel>>();
            Container.Register<ICoinRepository, CoinRepository>();
        }
    }
}