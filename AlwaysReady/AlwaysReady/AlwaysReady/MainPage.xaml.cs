using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;

namespace AlwaysReady
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        Page p = new Page();
        private string titulo;
        private string subtitulo;
        private string imagen1;
        private string imagen2;
        private string imagen3;

        public MainPage()
        {
            
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            //Inicio.Source = "Ini2.png";
            //Calendario.Source = "Cal1.png";
            //Tabla.Source = "Part1.png";
            //Noticia.Source = "Not1.png";
            //CODIGO CAROUSEL
            List<string> students = new List<string>()
                {
                    "List1.jpg",
                    "List11.jpg",
                    "List12.jpg",
                    "List13.jpg",
                };

            listViewCarousal.ItemsSource = students;

            Device.StartTimer(TimeSpan.FromSeconds(4), (Func<bool>)(() =>

            {

                int currentIndex = listViewCarousal.Position;
                int nextIndex = currentIndex < listViewCarousal.ItemsSource.OfType<object>().Count() - 1
                                    ? currentIndex + 1
                                    : 0;
                listViewCarousal.Position = nextIndex;

                return true;
            }));
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

        private async void metodosPop()
        {
            var pr = new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3);
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };

            pr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(pr);
        }
        private async void BotonPopup(object sender, EventArgs e)
        {
            titulo = "ALWAYS READY VS SPORT BOYS TORNEO CLAUSURA 2019";
            subtitulo = "Te mostramos algunas imágenes del partido que disputamos contra Sport Boys";
            imagen1 = "Pop1";
            imagen2 = "Pop2";
            imagen3 = "Pop3";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup2(object sender, EventArgs e)
        {
            titulo = "ALWAYS READY VS THE STRONGEST TORNEO CLAUSURA 2019";
            subtitulo = "Te mostramos algunas imágenes del partido que disputamos contra The Strongest, partido donde remontamos un dos a cero jugando un segundo tiempo con mucha intensidad, arrinconando al rival y presionando en todos los sectores.";
            imagen1 = "Pop4";
            imagen2 = "Pop5";
            imagen3 = "Pop6";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup3(object sender, EventArgs e)
        {
            titulo = "ALWAYS READY VS SAN JOSÉ TORNEO CLAUSURA 2019";
            subtitulo = "Te mostramos algunas imágenes del partido que disputamos contra San José por la décima Jornada de la División Profesional del Fútbol Boliviano";
            imagen1 = "Pop7";
            imagen2 = "Pop8";
            imagen3 = "Pop9";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup4(object sender, EventArgs e)
        {
            titulo = "PARTIDO 10.000 DE LA LIGA PROFESIONAL DEL FÚTBOL BOLIVIANO TORNEO CLAUSURA 2019";
            subtitulo = "El pasado 17 de agosto se disputo la octava fecha del Torneo Clausura, donde el partido entre Always Ready y Destroyer’s fue un encuentro único, debido a que jugaron el partido número 10.000 de la División Profesional de Futbol de Boliviano.";
            imagen1 = "Pop10";
            imagen2 = "Pop11";
            imagen3 = "Pop12";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }

    }
}
