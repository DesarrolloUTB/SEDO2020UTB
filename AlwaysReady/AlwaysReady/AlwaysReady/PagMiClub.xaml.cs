using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
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
    public partial class PagMiClub : ContentPage
    {
        private string fotojug;
        private string nombre;
        private string edad;
        private string naci;

        public PagMiClub()
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

        //Popup jugadores 
        private async void metodoPop()
        {
            var pr = new PopJugadores(fotojug, nombre, edad, naci);
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };
            pr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(pr);
        }
        private async void BotonDetalles(object sender, EventArgs e)
        {
            fotojug = "Jug1";
            nombre = "Portero";
            edad = "31";
            naci = "Santiago de Chile";
            metodoPop();
        }
        private async void BotonDetalles2(object sender, EventArgs e)
        {
            fotojug = "Jug2";
            nombre = "Portero";
            edad = "26";
            naci = "Tarija";
            metodoPop();
        }
        private async void BotonDetalles3(object sender, EventArgs e)
        {
            fotojug = "Jug3";
            nombre = "Defensa";
            edad = "30";
            naci = "Itsmina";
            metodoPop();
        }
        private async void BotonDetalles4(object sender, EventArgs e)
        {
            fotojug = "Jug4";
            nombre = "Defensa";
            edad = "23";
            naci = "Bolivia";
            metodoPop();
        }
        private async void BotonDetalles5(object sender, EventArgs e)
        {
            fotojug = "Jug5";
            nombre = "Defensa";
            edad = "25";
            naci = "Cochabamba";
            metodoPop();
        }
        private async void BotonDetalles6(object sender, EventArgs e)
        {
            fotojug = "Jug6";
            nombre = "Defensa";
            edad = "36";
            naci = "Asunción";
            metodoPop();
        }
    }
}