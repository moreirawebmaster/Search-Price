using System;
using System.Diagnostics;
using FreshMvvm;
using SearchPrice.App.Bootstraps;
using SearchPrice.App.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static FreshMvvm.FreshPageModelResolver;

namespace SearchPrice.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if(Debugger.IsAttached)
                HotReloader.Current.Start(this);

            IoCBootstrap.Init();

            var page = ResolvePageModel<HomePageModel>();
            MainPage = new FreshNavigationContainer(page);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
