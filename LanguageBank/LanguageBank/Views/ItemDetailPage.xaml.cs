using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LanguageBank.Models;
using LanguageBank.ViewModels;

namespace LanguageBank.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new WordCombination();

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}