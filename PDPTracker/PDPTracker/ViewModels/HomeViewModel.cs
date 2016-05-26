using System;
using Xamarin.Forms;

namespace PDPTracker
{
    public class HomeViewModel
    {
        Page _parentPage;

        public HomeViewModel (Page page)
        {
            _parentPage = page;

            if (!IsLoggedIn)
                _parentPage.Navigation.PushModalAsync (new LoginPage ());
        }

        public string ActivitiesTitle => "Activities";

        public bool IsLoggedIn => false;
    }
}

