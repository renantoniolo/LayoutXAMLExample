using System;
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

        public static MasterDetailPage myMasterDetailPage;

        public App()
        {
            InitializeComponent();

            // Exemplo Carrosel
            //MainPage = new CarouselPageExample();

            // Exemplo TabbedPage
            //MainPage = new TabbedPageExample();

            // Exemplo DetailPage
            //MainPage = new MyMasterDetailPageExample();

            //AbsoluteLayout
            //MainPage = new AbsoluteLayoutView();

            //RelativeLayout
            //MainPage = new RelativeLayoutView();

            //GridLayoutView
            //MainPage = new GridLayoutView();

            // ScroLayoutllView
            MainPage = new StackLayoutView();

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
