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
    public partial class PagCompra : ContentPage
    {
        public PagCompra()
        {
            InitializeComponent();
        }
        private void BotonInicio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        private void BotonCalendario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagCalendario());
        }
        private void BotonTabla(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagTabla());
        }
        private void BotonNoticia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagCompra());
        }
        private void BotonMiClub(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagMiClub());
        }
    }
}