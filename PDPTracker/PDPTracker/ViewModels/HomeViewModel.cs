using System;
using System.Collections.Generic;
using Hackathon.Spade.Model;
using Xamarin.Forms;

namespace PDPTracker
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly Page _parentPage;

        #region Properties

        public string ActivitiesTitle => "Activities";

        public bool IsLoggedIn => false;


        private List<Activity> _activities;
        public List<Activity> Activities
        {
            get { return _activities; }
            set
            {
                _activities = value; 
                OnPropertyChanged();
            }
        }

        public Activity SelectedActivity {
            set
            {
                if (value == null) return;

                _parentPage.Navigation.PushAsync(new ActivityPage(value));
            }
        }

        #endregion

        public HomeViewModel (Page page)
        {
            _parentPage = page;

            if (!IsLoggedIn)
                _parentPage.Navigation.PushModalAsync (new LoginPage ());

            PopulateSampleData();
        }

        private void PopulateSampleData()
        {
            Activities = new List<Activity>
            {
                new Activity { Description = "Finished Xamarin certification", CompletedDate = DateTime.Parse("10-Oct-2015") },
                new Activity { Description = "Flew to Atlanta for Newell sales meeting", CompletedDate = DateTime.Parse("12-Dec-2015") },
                new Activity { Description = "Sat in ADP meeting for Stu", CompletedDate = DateTime.Parse("15-Jan-2016") },
                new Activity { Description = "Finished MSCD certification", CompletedDate = DateTime.Parse("1-Feb-2016") },
                new Activity { Description = "Transocean lunch and learn", CompletedDate = DateTime.Parse("25-May-2016") }
            };
        }
    }
}

