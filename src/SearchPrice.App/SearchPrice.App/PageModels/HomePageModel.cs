using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using SearchPrice.App.Models;
using SearchPrice.App.Repositories.Abstracts;
using SearchPrice.App.Services;
using Xamarin.Forms;

namespace SearchPrice.App.PageModels
{
    public class HomePageModel : BasePageModel
    {
        private readonly IPtaxService _service;
        private readonly ICoinRepository _coinRepository;

        public ICommand DetailCoinCommand => new Command<CoinModel>(async (obj)=>
            {
                await CoreMethods.PushPageModel<DetailCoinPageModel>(obj);
            });

        public ObservableCollection<CoinModel> Coins { get; set; }

        public HomePageModel(IPtaxService service, ICoinRepository coinRepository)
        {
            _service = service;
            _coinRepository = coinRepository;
        }


        public override async void Init(object initData)
        {
            var coins = await _coinRepository.GetCoinsAsync().ConfigureAwait(true);

            if (!coins.Any())
            {
                var result = await _service.GetCoinsAsync().ConfigureAwait(true);
                await _coinRepository.InsertAsync(result.Value).ConfigureAwait(false);

                coins = result.Value;
            }

            Coins = new ObservableCollection<CoinModel>(coins);

        }
    }
}