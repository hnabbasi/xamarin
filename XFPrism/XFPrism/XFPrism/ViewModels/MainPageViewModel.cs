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
        //private readonly IPageDialogService _dialogService;
        private readonly INavigationService _navigationService;

        #region Constructor

        public MainPageViewModel(ISayHello sayHelloService, INavigationService navigationService) //, IPageDialogService dialogService)
        {
            _sayHelloService = sayHelloService;
            _navigationService = navigationService;
            //_dialogService = dialogService;

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
            //_dialogService.DisplayAlertAsync("Dialog Service", "Hi", "OK");
            _sayHelloService.SayHello("Forms says Hi");
        }
        
        #endregion
    }
}
