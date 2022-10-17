using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BENIPLAS.INTERFACES;

namespace BENIPLAS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class interfaz : ContentPage
    {
        public interfaz()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
        async private void CERRS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new login());
        }

        async private void CI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CorreoInterfaz());
        }
    }
}