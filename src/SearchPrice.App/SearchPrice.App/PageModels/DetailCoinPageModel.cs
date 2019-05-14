using System;
using System.Collections.ObjectModel;
using Refit;
using SearchPrice.App.Models;
using SearchPrice.App.Services;

namespace SearchPrice.App.PageModels
{
    public class DetailCoinPageModel : BasePageModel
    {
        private readonly IPtaxService _service;

        public ObservableCollection<DetailCoinModel> Details { get; set; }
        public CoinModel CoinModel { get; set; }

        public DetailCoinPageModel(IPtaxService service)
        {
            _service = service;
        }

        public override async void Init(object initData)
        {

            try
            {
                CoinModel = initData as CoinModel;
                var result = await _service.GetDetailCoinsAsync(CoinModel.Simbolo, DateTime.Now.ToString("MM-dd-yyyy")).ConfigureAwait(true);

                Details = new ObservableCollection<DetailCoinModel>(result.Value);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}