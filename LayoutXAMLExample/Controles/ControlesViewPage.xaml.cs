using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXAMLExample.Controles
{
    public partial class ControlesViewPage : ContentPage
    {
        public ControlesViewPage()
        {
            InitializeComponent();
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();

            xLabel.Text = "Renan toniolo";

            await XProgressBar.ProgressTo(.4, 250, Easing.Linear);
            XProgressBar.Progress = 0.5;
            Debug.WriteLine("Animation completed");

            XDataPicker.Date = DateTime.Now;
           
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var toggled = e.Value;

            DisplayAlert("O valor da Toggle é ", toggled.ToString(), "OK");

        }


        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var xvalue = e.NewValue;
            Debug.WriteLine("O valor do Slider é: " + xvalue.ToString());
        }



        void Handle_ValueChanged_1(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var valor = e.NewValue;

            xLabel.Text = valor.ToString();
        }


        async Task Handle_Clicked(object sender, System.EventArgs e)
        {

            var ret = XCheck.IsToggled;

            var retorn = await DisplayAlert("O valor da Label é ", xLabel.Text,"SIM","Cancel");

            XActivityIndicator.IsVisible = true;
            XActivityIndicator.IsRunning = true;
        }
    }
}
