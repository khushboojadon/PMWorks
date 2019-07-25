using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signature : ContentPage
    {
        public Signature()
        {
            InitializeComponent();
        }

        private async void ForwardButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignatureUploadStatus());
        }

        private async void BackBtnClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}