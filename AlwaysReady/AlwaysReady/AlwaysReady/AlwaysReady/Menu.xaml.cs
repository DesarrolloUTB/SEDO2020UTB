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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;

            if ((mainPage as MasterDetailPage).IsPresented)
            {
                (mainPage as MasterDetailPage).IsPresented = false;
            }
            else
            {
                (mainPage as MasterDetailPage).IsPresented = true;
            }
        }

        private void BotonNotificacion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuNotificacion());
        }
        private void BotonTienda(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagCompra());
        }
        private void BotonIniSec(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuIniSecion());
        }
        private void BotonHistoria(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuHistoria());
        }
        private void BotonTerminos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuTerminos());
        }
        private void BotonVideos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuMultimedia());
        }
        private void BotonFace(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/ClubAlwaysReady.Bo"));
        }
        private void BotonTwiter(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/ClubAlwaysReady"));
        }
        private void BotonYouTube(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/channel/UCeJKBZolAeVgs6EKkH5McyA"));
        }
    }
}