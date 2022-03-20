using Android.Content;
using ios_renderer;
using ios_renderer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SunnyEntry), typeof(SunnyEntryRenderer))]

namespace ios_renderer.Droid
{
    public class SunnyEntryRenderer : EntryRenderer
    {
        public SunnyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                Control.SetBackgroundColor(AwesomeControl.Shared.Color.ToAndroid());
        }
    }
}