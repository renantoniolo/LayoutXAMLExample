using System;
using System.Collections.Generic;
using LayoutXAMLExample.NavigationPageExample;
using Xamarin.Forms;

namespace LayoutXAMLExample.MasterDetailPageExample
{
    public partial class MyMasterDetailPageExample : MasterDetailPage
    {
        public MyMasterDetailPageExample()
        {
            InitializeComponent();


            // seto minha master page para ser acessada de onde eu estiver
            App.myMasterDetailPage = this;

            // Master é onde fica o menu
            this.Master = new MasterPageExample();

            // A pagina que vai ser aberta
            this.Detail = new NavigationPage(new NavigationPageExampleRaiz());
        }
    }
}
