using AwesomeControl;
using AwesomeControl.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AwesomeEntry), typeof(AwesomeEntryRenderer))]

namespace AwesomeControl.iOS
{
    public class AwesomeEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = AwesomeControl.Shared.Color.ToUIColor();
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}