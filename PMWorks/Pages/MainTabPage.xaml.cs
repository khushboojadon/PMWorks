using System;
using System.Collections.Generic;
using PMWorks.Effects;
using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class MainTabPage : TabbedPage
    {
        //static IDictionary<Type, Color> colorMap = new Dictionary<Type, Color>
        //{
        //    { typeof(SelectHotelPage), Color.FromHex("#00D6D8") },
        //    { typeof(NotificationsPage), Color.FromHex("#00D6D8") },
        //    { typeof(ProfilePage), Color.FromHex("#00D6D8") }
        //};

        //public Color SelectedTabTintColor
        //{
        //    get { return (Color)GetValue(SelectedTabTintColorProperty); }
        //    set { SetValue(SelectedTabTintColorProperty, value); }
        //}

        //public static readonly BindableProperty SelectedTabTintColorProperty =
        //BindableProperty.Create(nameof(SelectedTabTintColor), typeof(Color), typeof(MainTabPage));

        public MainTabPage()
        {
            var selectPage = new NavigationPage(new SelectHotelPage());
            selectPage.IconImageSource = "home.png";
            selectPage.Title = "Home";

            Children.Add(selectPage);

            var notifyPage = new NavigationPage(new NotificationsPage());
            notifyPage.IconImageSource = "notification.png";
            notifyPage.Title = "Notifications";

            Children.Add(notifyPage);

            var profilePage = new NavigationPage(new ProfilePage());
            profilePage.IconImageSource = "profile.png";
            profilePage.Title = "Profile";

            Children.Add(profilePage);

            BindingContext = this;
            // Effects.Add(new TabbedPageSelectedTabItemDynamicTintColorEffect());
            //SetBinding(SelectedTabItemDynamicTintColorEffect.SelectedTabTintColorProperty, new Binding { Source = this, Path = SelectedTabTintColorProperty.PropertyName });
            // Adding the first child will trigger `OnCurrentPageChanged` immediately, therefore we should take care of bindings beforehand
            InitializeComponent();
        }
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            // SelectedTabTintColor = colorMap[CurrentPage.GetType()];
        }

    }
}