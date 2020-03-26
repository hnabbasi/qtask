using QTask.ViewModels;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace QTask.Views
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Always);
        }
    }
}
