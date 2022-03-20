using Android.Content;
using AwesomeControl;
using AwesomeControl.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AwesomeEntry), typeof(AwesomeEntryRenderer))]

namespace AwesomeControl.Droid
{
    public class AwesomeEntryRenderer : EntryRenderer
    {
        public AwesomeEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
        }
    }
}