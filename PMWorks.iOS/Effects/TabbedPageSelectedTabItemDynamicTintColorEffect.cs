using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PMWorks.Effects;
using System.Linq;

[assembly: ResolutionGroupName("PMWorks.Effects")]
[assembly: ExportEffect(typeof(PMWorks.iOS.Effects.TabbedPageSelectedTabItemDynamicTintColorEffect), nameof(TabbedPageSelectedTabItemDynamicTintColorEffect))]
namespace PMWorks.iOS.Effects
{
    public class TabbedPageSelectedTabItemDynamicTintColorEffect : PlatformEffect
    {
        protected override void OnAttached() { }
        protected override void OnDetached() { }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == SelectedTabItemDynamicTintColorEffect.SelectedTabTintColorProperty.PropertyName)
                SetTintColor();
        }

        void SetTintColor()
        {
            var tabBar = Container.Subviews.First(v => v is UIKit.UITabBar);
            tabBar.TintColor = SelectedTabItemDynamicTintColorEffect.GetSelectedTabTintColor(Element).ToUIColor();
        }
    }
}
