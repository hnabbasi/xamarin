using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PDPTracker
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel _vm;

        public HomePage ()
        {
            _vm = new HomeViewModel (this);
            BindingContext = _vm;


            InitializeComponent ();
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            Navigation.PushAsync (new ActivityPage ());
        }
    }
}

