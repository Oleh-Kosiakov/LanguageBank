using LanguageBank.Controls;
using LanguageBank.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedItemCell), typeof(ExtendedItemCellIosRenderer))]
namespace LanguageBank.iOS.Renderers
{
    public class ExtendedItemCellIosRenderer : ViewCellRenderer
    {
        private ExtendedItemCell _cell;

        public ExtendedItemCellIosRenderer()
        {

        }
    }
}
