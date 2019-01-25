using LanguageBank.Models;

namespace LanguageBank.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public WordCombination Item { get; set; }
        public ItemDetailViewModel(WordCombination item = null)
        {
            Title = item?.Foreign;
            Item = item;
        }
    }
}
