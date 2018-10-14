using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutXAMLExample.NavigationPageExample
{
    public partial class NavigationPageExampleRaiz : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new NavigationPageExample01());
        }

        public NavigationPageExampleRaiz()
        {
            InitializeComponent();
        }
    }
}
