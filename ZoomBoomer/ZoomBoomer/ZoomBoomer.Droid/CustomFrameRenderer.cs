using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ZoomBoomer;
using ZoomBoomer.Droid;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace ZoomBoomer.Droid
{
    public class CustomFrameRenderer : FrameRenderer
    {
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
        }
    }
}