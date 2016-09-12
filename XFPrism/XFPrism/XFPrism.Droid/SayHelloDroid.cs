using Android.Widget;
using Xamarin.Forms;
using XFPrism.Droid;
using XFPrism.Interface;
using Application = Android.App.Application;

[assembly:Dependency(typeof(SayHelloDroid))]
namespace XFPrism.Droid
{
    public class SayHelloDroid : ISayHello
    {
        public void SayHello(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}