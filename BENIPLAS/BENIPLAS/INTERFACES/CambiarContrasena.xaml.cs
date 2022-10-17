using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BENIPLAS.INTERFACES
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CambiarContrasena : ContentPage
    {
        public CambiarContrasena()
        {
            InitializeComponent();
        }

       async private void R_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new interfaz());
        }
    }
}