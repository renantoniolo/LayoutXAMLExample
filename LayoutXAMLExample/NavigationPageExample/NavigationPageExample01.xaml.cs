using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutXAMLExample.NavigationPageExample
{
    public partial class NavigationPageExample01 : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new NavigationPageExample02(),true);
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }

        public NavigationPageExample01()
        {
            InitializeComponent();
        }
    }
}
