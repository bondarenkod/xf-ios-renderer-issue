using ios_renderer;
using ios_renderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SunnyEntry), typeof(SunnyEntryRenderer))]

namespace ios_renderer.iOS
{
    public class SunnyEntryRenderer : EntryRenderer
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