using LanguageBank.Controls;
using LanguageBank.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(ExtendedItemNativeCell), typeof(ExtendedItemCellIosRenderer))]
namespace LanguageBank.iOS.Renderers
{
    public class ExtendedItemCellIosRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var xamarinFormsCell = item as ExtendedItemNativeCell;

            var baseCell = base.GetCell(item, reusableCell, tv);
            baseCell.AddGestureRecognizer(new UILongPressGestureRecognizer(() => { xamarinFormsCell.OnLongPressed(); }));

            return baseCell;
        }
    }
}
