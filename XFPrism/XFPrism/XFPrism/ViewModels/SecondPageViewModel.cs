using System.Linq;
using Prism.Commands;
using Prism.Navigation;
using XFPrism.Interface;
using XFPrism.Views;

namespace XFPrism.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ISayHello _sayHelloService;
        public SecondPageViewModel(INavigationService navigationService, ISayHello sayHelloService)
        {
            _navigationService = navigationService;
            _sayHelloService = sayHelloService;
            Title = "Home";
        }
        public DelegateCommand LoginCommand => new DelegateCommand(OnLogin);

        private void OnLogin()
        {
            _navigationService.NavigateAsync(nameof(LoginPage), useModalNavigation:true);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            if (!parameters.Any())
                return;

            var sender = (string) parameters[AppConstants.Sender];
            var result = (bool) parameters[AppConstants.LoginSuccess] ? "Login successful" : "Login failed";

            ShowDialog($"{sender} says, {result}");

            base.OnNavigatedTo(parameters);
        }

        internal void ShowDialog(string msg)
        {
            _sayHelloService.SayHello(msg);
        }
    }
}
