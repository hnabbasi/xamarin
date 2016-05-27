using System;
using System.Collections.Generic;
using Hackathon.Spade.Model;
using Xamarin.Forms;

namespace PDPTracker
{
    public partial class ActivityPage : ContentPage
    {
        readonly ActivityViewModel _vm;
        public ActivityPage ()
        {
            InitializeComponent ();
            _vm = new ActivityViewModel (this);
            BindingContext = _vm;
        }

        public ActivityPage(Activity activity)
        {
            InitializeComponent();
            _vm = new ActivityViewModel(this, activity);
            BindingContext = _vm;
        }
    }
}

