using ios_renderer.Services;
using ios_renderer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ios_renderer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
