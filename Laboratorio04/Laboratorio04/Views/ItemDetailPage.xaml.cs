using Laboratorio04.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Laboratorio04.Views
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