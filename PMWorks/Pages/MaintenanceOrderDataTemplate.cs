using Xamarin.Forms;

namespace PMWorks.Pages
{
    public class MaintenanceOrderDataTemplate : DataTemplateSelector
    {
        public DataTemplate MaintenanceListOrder { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return MaintenanceListOrder;
        }
    }
}
