using System;
using QTask.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(NavigationPage), typeof(NavigationPageRenderer))]
namespace QTask.iOS.Renderers
{
    public class NavigationPageRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}
