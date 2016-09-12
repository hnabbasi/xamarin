using Prism.Navigation;
using Prism.Unity;
using XFPrism.Views;

namespace XFPrism
{
    public class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("RootPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<RootPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SecondPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
        }
    }
}