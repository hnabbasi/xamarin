using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;

namespace XFPrism.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        #region Properties

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        #endregion

        #region Constructor

        public BaseViewModel() { }

        #endregion

        #region Overridables

        public virtual void OnNavigatedFrom(NavigationParameters parameters) { }

        public virtual void OnNavigatedTo(NavigationParameters parameters) { }

        #endregion

    }
}
