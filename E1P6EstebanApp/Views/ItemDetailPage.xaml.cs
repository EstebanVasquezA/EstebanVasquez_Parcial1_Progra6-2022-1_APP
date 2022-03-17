using E1P6EstebanApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace E1P6EstebanApp.Views
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