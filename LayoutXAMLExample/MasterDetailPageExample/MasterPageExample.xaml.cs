using System;
using System.Collections.Generic;
using LayoutXAMLExample.NavigationPageExample;
using LayoutXAMLExample.PagesExample;
using Xamarin.Forms;

namespace LayoutXAMLExample.MasterDetailPageExample
{
    public partial class MasterPageExample : ContentPage
    {
        public MasterPageExample()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            App.myMasterDetailPage.Detail = new NavigationPage(new NavigationPageExample01());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            App.myMasterDetailPage.Detail = new NavigationPage(new CarouselPageExample());
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            App.myMasterDetailPage.Detail = new NavigationPage(new TabbedPageExample());
        }

    }
}
