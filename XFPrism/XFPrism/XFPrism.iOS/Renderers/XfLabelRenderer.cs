using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFPrism.Controls;
using XFPrism.iOS.Renderers;

[assembly: ExportRenderer(typeof(XfLabel), typeof(XfLabelRenderer))]
namespace XFPrism.iOS.Renderers
{
    public class XfLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.TextColor = UIColor.Purple;
        }
    }
}
