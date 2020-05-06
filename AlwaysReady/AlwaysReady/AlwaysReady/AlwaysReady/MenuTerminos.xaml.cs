using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlwaysReady
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuTerminos : ContentPage
    {
        public MenuTerminos()
        {
            InitializeComponent();
        }
        private async void BotonUtb(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://utb.edu.bo/inicio/"));
        }
        private async void BotonAmazonas(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://amaszonas.com/es-bo/"));
        }
        private async void BotonTigo(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tigo.com.bo/"));
        }
        private async void BotonBago(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.bago.com.bo/"));
        }
        private async void BotonSuzuki(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.suzuki.com.bo/"));
        }
        private async void BotonPasena(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.cbn.bo/"));
        }
        private async void BotonBisa(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.bisa.com/"));
        }
    }
}