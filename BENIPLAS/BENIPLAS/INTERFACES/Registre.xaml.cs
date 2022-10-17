using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BENIPLAS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registre : ContentPage
    {
       

        public Registre()
        {
            InitializeComponent();
            
        }

       async private void REG_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new interfaz());
        }
    }
}