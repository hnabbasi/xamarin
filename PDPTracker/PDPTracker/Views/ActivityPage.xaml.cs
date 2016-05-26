using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PDPTracker
{
    public partial class ActivityPage : ContentPage
    {
        ActivityViewModel _vm;
        public ActivityPage ()
        {
            InitializeComponent ();
            _vm = new ActivityViewModel (this);
            BindingContext = _vm;
        }
    }
}

