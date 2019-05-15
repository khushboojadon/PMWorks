using System;
using System.Collections.Generic;
using PMWorks.Models;
using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class FilterScreen : ContentPage
    {
        public FilterScreen()
        {
            InitializeComponent();
            MyList.ItemsSource = new CatogriesList().ListOfCategory();

        }
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            //textlbl.Text = isToggled.ToString();
        }

    }
}
