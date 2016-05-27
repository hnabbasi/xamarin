using System;
using Hackathon.Spade.Model;
using Xamarin.Forms;

namespace PDPTracker
{
    public class ActivityViewModel : BaseViewModel
    {
        Page _parentPage;

        public string ActivityTitle => "Activity Details";

        public Activity Activity { get; set; }

        public ActivityViewModel (Page page)
        {
            _parentPage = page;
        }

        public ActivityViewModel(Page page, Activity activity)
        {
            this._parentPage = page;
            this.Activity = activity;
        }

    }
}

