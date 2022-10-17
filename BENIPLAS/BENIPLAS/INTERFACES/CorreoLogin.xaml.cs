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
    public partial class CorreoLogin : ContentPage
    {
        public CorreoLogin()
        {
            InitializeComponent();
        }

       async private void REGRESAR_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new login());
        }

        private void ENVL_Clicked(object sender, EventArgs e)
        {

        }
    }
}