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

            xLabel.Text = "Renan Toniolo Rocha";

            //await XProgressBar.ProgressTo(.4, 250, Easing.Linear);
            //Debug.WriteLine("Animation completed");
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var toggled = e.Value;

            DisplayAlert("O vaor da Toggle é ", toggled.ToString(), "OK");

        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var xvalue = e.NewValue;
            Debug.WriteLine("O vaor do Slider é: " + xvalue.ToString());
        }

        void Handle_ValueChanged_1(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var valor = e.NewValue;

            xLabel.Text = valor.ToString();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("O vaor da Label é ", xLabel.Text,"OK");

            XActivityIndicator.IsVisible = true;
            XActivityIndicator.IsRunning = true;
        }
    }
}
