using System.ComponentModel;
using Xamarin.Forms;
using ShellMemLeakTest.ViewModels;

namespace ShellMemLeakTest.Views
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
