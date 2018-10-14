using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutXAMLExample.NavigationPageExample
{
    public partial class NavigationPageExample02 : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }

        public NavigationPageExample02()
        {
            InitializeComponent();
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            this.Navigation.PopToRootAsync();
        }
    }
}
