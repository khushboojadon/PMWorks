using Xamarin.Forms;

namespace PMWorks.Pages
{
    public class HotelDataTemplate : DataTemplateSelector
    {
        public DataTemplate HotelListTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return HotelListTemplate;
        }
    }
}
