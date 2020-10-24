using System.ComponentModel;
using Xamarin.Forms;
using MessagingCenterSample.ViewModels;

namespace MessagingCenterSample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}