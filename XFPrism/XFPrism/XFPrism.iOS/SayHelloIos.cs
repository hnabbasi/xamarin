using UIKit;
using XFPrism.iOS;
using XFPrism.Interface;

[assembly:Xamarin.Forms.Dependency(typeof(SayHelloIos))]
namespace XFPrism.iOS
{
    public class SayHelloIos : ISayHello
    {
        public void SayHello(string message)
        {
            var hello = new UIAlertView("Hi", message, null, "OK",null);
            hello.Show();
        }
    }
}
