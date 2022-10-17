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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();

        }

        async private void In_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registre());
        }

        async private void Ol_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CorreoLogin());
        }
    }
}