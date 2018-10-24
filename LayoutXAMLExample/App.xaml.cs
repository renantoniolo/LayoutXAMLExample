using System;
using LayoutXAMLExample.Controles;
using LayoutXAMLExample.Layout;
using LayoutXAMLExample.MasterDetailPageExample;
using LayoutXAMLExample.NavigationPageExample;
using LayoutXAMLExample.PagesExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LayoutXAMLExample
{
    public partial class App : Application
    {
        // guardo minha masterdetailpage p/ ser acessada de onde eu estiver
        public static MasterDetailPage myMasterDetailPage;

        public App()
        {
            InitializeComponent();

            // Exemplo Carrosel
            //MainPage = new CarouselPageExample();

            // Exemplo TabbedPage
            //MainPage = new TabbedPageExample();

            // Exemplo DetailPage
            MainPage = new MyMasterDetailPageExample();

            //AbsoluteLayout
            //MainPage = new AbsoluteLayoutView();

            //RelativeLayout
            //MainPage = new RelativeLayoutView();

            //ControlesViewPage
            //MainPage = new ControlesViewPage();

            // ScroLayoutllView
           // MainPage = new ScrollLayoutView();

            // Exemplo NavigationPage
            //MainPage = new NavigationPage(new NavigationPageExampleRaiz());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
