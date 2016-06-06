using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ZoomBoomer
{
    public partial class HomePage : ContentPage
    {
        readonly HomepageViewModel _vm;
        public HomePage()
        {
            InitializeComponent();
            _vm = new HomepageViewModel(this);
            BindingContext = _vm;
        }
        
    }
}
