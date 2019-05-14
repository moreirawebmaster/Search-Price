using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchPrice.App.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchPrice.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePageModel Model => (HomePageModel) BindingContext;

        public HomePage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(Model.DetailCoinCommand.CanExecute(null))
                Model.DetailCoinCommand.Execute(e.Item);
        }
    }
}