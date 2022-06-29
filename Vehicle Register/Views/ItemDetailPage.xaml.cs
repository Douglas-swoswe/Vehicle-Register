using System.ComponentModel;
using Vehicle_Register.ViewModels;
using Xamarin.Forms;

namespace Vehicle_Register.Views
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