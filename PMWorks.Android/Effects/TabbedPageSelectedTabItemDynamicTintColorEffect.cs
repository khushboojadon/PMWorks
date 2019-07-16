
using System.ComponentModel;
using PMWorks.Effects;
using Xamarin.Forms.Platform.Android;

namespace PMWorks.Droid.Effects
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

        void SetTintColor() =>
            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetBarSelectedItemColor(Element, SelectedTabItemDynamicTintColorEffect.GetSelectedTabTintColor(Element));
    }
}
