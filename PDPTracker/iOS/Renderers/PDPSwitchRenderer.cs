using System;
using PDPTracker;
using PDPTracker.Controls;
using PDPTracker.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(PDPSwitch), typeof(PDPSwitchRenderer))]
namespace PDPTracker.iOS
{
    public class PDPSwitchRenderer : SwitchRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Switch> e)
        {
            base.OnElementChanged (e);

            if (Control == null)
                return;
            
            Control.TintColor = UIColor.FromRGB(79,20,26);
            Control.OnTintColor = UIColor.FromRGB(79, 20, 26);
        }
    }
}

