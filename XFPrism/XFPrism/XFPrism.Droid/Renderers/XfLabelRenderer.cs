using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFPrism.Controls;
using XFPrism.Droid.Renderers;

[assembly:ExportRenderer(typeof(XfLabel), typeof(XfLabelRenderer))]
namespace XFPrism.Droid.Renderers
{
    public class XfLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.SetTextColor(Android.Graphics.Color.Purple);
        }
    }
}