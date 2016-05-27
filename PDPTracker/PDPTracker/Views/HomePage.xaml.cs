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
            InitializeComponent();
            _vm = new HomeViewModel (this);
            BindingContext = _vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ActivitiesList.SelectedItem != null)
                ActivitiesList.SelectedItem = null;
        }
    }
}

