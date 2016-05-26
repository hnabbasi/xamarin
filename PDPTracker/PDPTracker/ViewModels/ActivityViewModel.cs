using System;
using Xamarin.Forms;

namespace PDPTracker
{
    public class ActivityViewModel : BaseViewModel
    {
        Page _parentPage;

        public ActivityViewModel (Page page)
        {
            _parentPage = page;
        }

        public string ActivityTitle => "Activity Details";
    }
}

