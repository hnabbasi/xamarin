using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace XFPrism.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "Login";
        }

        private bool _isSuccess;
        public bool IsSuccess
        {
            get { return _isSuccess; }
            set { SetProperty(ref _isSuccess, value); }
        }

        public DelegateCommand DoneCommand => new DelegateCommand(OnDone);

        private void OnDone()
        {
            var navParams = new NavigationParameters
            {
                {AppConstants.Sender, this.GetType().Name},
                {AppConstants.LoginSuccess, IsSuccess}
            };

            _navigationService.GoBackAsync(navParams);
        }
    }
}
