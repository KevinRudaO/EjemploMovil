using EjemploMovil.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EjemploMovil.Views
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