using Android.Content;
using Android.Views;
using LanguageBank.Controls;
using LanguageBank.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedItemNativeCell), typeof(ExtendedItemCellAndroidRenderer))]
namespace LanguageBank.Droid.Renderers
{
    public class ExtendedItemCellAndroidRenderer : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var xamarinFormsCell = item as ExtendedItemNativeCell;
            var baseCell = base.GetCellCore(item, convertView, parent, context);

            baseCell.LongClick += (sender, e) => { xamarinFormsCell.OnLongPressed(); };

            return baseCell;
        }
    }
}
