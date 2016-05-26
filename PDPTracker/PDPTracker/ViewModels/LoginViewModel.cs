using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PDPTracker
{
    public class LoginViewModel : BaseViewModel
    {
        #region Private Fields

        readonly Page _parentPage;

        #endregion

        #region Constructor

        public LoginViewModel (Page parentPage)
        {
            _parentPage = parentPage;
        }

        #endregion

        #region Properties

        #region Login Title

        string _loginTitle = "PDP Tracker";

        public string LoginTitle {
            get { 
                return _loginTitle; 
            }
            set {
                _loginTitle = value;
                OnPropertyChanged ();
            }
        }
        #endregion

        #region Username

        string _username;

        public string Username {
            get {
                return _username;
            }

            set {
                _username = value;
                OnPropertyChanged ();
            }
        }
        #endregion

        #region Password

        string _password;

        public string Password {
            get {
                return _password;
            }

            set {
                _password = value;
                OnPropertyChanged ();
            }
        }

        #endregion

        #region Remember Me

        bool _shouldRemember = true;          public bool ShouldRemember {             get { 
                return _shouldRemember; 
            }             set {
                _shouldRemember = value;
                OnPropertyChanged ();}         } 

        #endregion

        #endregion

        #region Commands

        public ICommand LoginCommand => new Command (OnLogin);

        #endregion

        #region Private Methods

        void OnLogin ()
        {
            if (string.IsNullOrWhiteSpace (Username) || string.IsNullOrWhiteSpace (Password))
                return;
            
            _parentPage.Navigation.PopModalAsync ();
        }

        #endregion
    }
}
