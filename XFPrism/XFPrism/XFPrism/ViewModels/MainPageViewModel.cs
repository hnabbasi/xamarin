using System.Windows.Input;
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
        private readonly IPageDialogService _dialogService;
        private readonly INavigationService _navigationService;

        #region Constructor

        public MainPageViewModel(INavigationService navigationService, ISayHello sayHelloService, IPageDialogService dialogService)
        {
            _sayHelloService = sayHelloService;
            _dialogService = dialogService;
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

        #region SayHiCommand

        public ICommand SayHiCommand => new DelegateCommand(OnSayHiCommand);

        private void OnSayHiCommand()
        {
            _dialogService.DisplayAlertAsync("Dialog Service", "Hi", "OK");
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
