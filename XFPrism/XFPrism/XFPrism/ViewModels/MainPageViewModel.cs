using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using XFPrism.Interface;
using XFPrism.Views;

namespace XFPrism.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly ISayHello _sayHelloService;
        private readonly INavigationService _navigationService;

        #region Constructor

        public MainPageViewModel(ISayHello sayHelloService, INavigationService navigationService)
        {
            _sayHelloService = sayHelloService;
            _navigationService = navigationService;

            Title = "Welcome";
            Initialize();
        }


        #endregion

        #region Commands

        #region HomeCommand

        public DelegateCommand HomeCommand => new DelegateCommand(OnHomeCommand);

        private void OnHomeCommand()
        {
            _navigationService.NavigateAsync(nameof(SecondPage));
        }

        #endregion

        #endregion

        #region Private Methods
        
        private void Initialize()
        {
            _sayHelloService.SayHello("Forms says Hi");
        }
        
        #endregion
    }
}
