using System;
using MvvmHelpers;
using Xamarin.Essentials.Interfaces;

namespace QTask.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly IAppInfo _appInfo;
        public AboutViewModel(IAppInfo appInfo)
        {
            Title = "About";
            _appInfo = appInfo;
        }

        public string AppName => _appInfo.Name;
        public string AppVersion => _appInfo.VersionString;
    }
}
