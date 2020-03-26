using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using QTask.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;

namespace QTask
{
    [AutoRegisterForNavigation]
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainView)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.Register<IAppInfo, AppInfoImplementation>();
        }
    }
}
