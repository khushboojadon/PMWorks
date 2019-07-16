using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static PMWorks.Models.BrokenList;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MaintenanceOrderFilter : ContentPage
	{
		public MaintenanceOrderFilter ()
		{
			InitializeComponent ();
            MyList.ItemsSource = new Brokenlist().ListOfItems();
        }

        private async void btnForwardClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Signature());
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
           // check_btn.Source = "checked";
            //broken_img.Source = "tabimg";
            //MyList.IsVisible = false;
         //  ListImg.Source = "checked";
        }
        void broken_imgClicked(object sender, System.EventArgs e)
        {
           // broken_img.Source = "checked";
         //  ListImg.Source = "tabimg";
           // check_btn.Source = "tabimg";
        }

        private async void BtnSubmit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Signature());
        }
    }
}