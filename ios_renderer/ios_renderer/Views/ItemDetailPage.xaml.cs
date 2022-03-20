using ios_renderer.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ios_renderer.Views
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