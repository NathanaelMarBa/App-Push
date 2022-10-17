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
    public partial class CorreoInterfaz : ContentPage
    {
        public CorreoInterfaz()
        {
            InitializeComponent();
        }

       async private void REGRESARC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new interfaz());
        }

        private void ENV_Clicked(object sender, EventArgs e)
        {

        }
    }
}