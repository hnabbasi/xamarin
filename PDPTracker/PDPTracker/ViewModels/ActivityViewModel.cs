using System;
using Hackathon.Spade.Model;
using Xamarin.Forms;

namespace PDPTracker
{
    public class ActivityViewModel : BaseViewModel
    {
        Page _parentPage;

        public string ActivityTitle => "Activity Details";

        private Activity _activity;
        public Activity Activity
        {
            get { return _activity; }
            set { _activity = value; OnPropertyChanged();}
        }

        public string Description {
            get { return Activity.Description; }
            set
            {
                Activity.Description = value;
                OnPropertyChanged();
            }
        }

        public DateTime? CompletedDate {
            get { return Activity.CompletedDate; }
            set
            {
                Activity.CompletedDate = value;
                OnPropertyChanged();
            }
        }

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

