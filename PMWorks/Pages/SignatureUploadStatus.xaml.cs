using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignatureUploadStatus : ContentPage
    {
        public SignatureUploadStatus()
        {
            InitializeComponent();
        }

        private async void Continue_Clicked(object sender, EventArgs e)
        {
            for (var counter = 1; counter < 3; counter++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            }
            await Navigation.PopAsync();
        }
    }
}