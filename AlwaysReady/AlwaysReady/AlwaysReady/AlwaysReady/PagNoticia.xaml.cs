using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;

namespace AlwaysReady
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagNoticia : ContentPage
    {
        private string titulo;
        private string subtitulo;
        private string imagen1;
        private string imagen2;
        private string imagen3;
        public PagNoticia()
        {
            InitializeComponent();
            

            //Inicio.Source = "Ini2.png";
            //Calendario.Source = "Cal1.png";
            //Tabla.Source = "Part1.png";
            //Noticia.Source = "Not1.png";
            //CODIGO CAROUSEL
            List<string> students = new List<string>()
                {
                    "Caru1.jpg",
                    "Caru2.jpg",
                    "Caru3.jpg",
                    "Caru4.jpg",
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
            titulo = "ALWAYS READY 4 – THE STRONGEST 1";
            subtitulo = "Te mostramos algunas imágenes del partido que disputamos contra Strongest. Un partido donde se vio el potencial con el que cuenta el equipo. Se jugó a buen ritmo, donde se presionó al equipo rival en todas sus líneas.";
            imagen1 = "Noti1A";
            imagen2 = "Noti1B";
            imagen3 = "Noti1C";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup2(object sender, EventArgs e)
        {
            titulo = "ALWAYS READY 1 – AURORA 0";
            subtitulo = "Te mostramos algunas imágenes del partido que disputamos contra Aurora, partido que se disputo este sábado 25 de enero en el Estadio Municipal de El Alto. El equipo millonario domino todo el encuentro, acorralando a su rival lo que nos permitió llevarnos la victoria. Este fue el primer paso para conseguir nuestro objetivo.";
            imagen1 = "Noti2A";
            imagen2 = "Noti2B";
            imagen3 = "Noti2C";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup3(object sender, EventArgs e)
        {
            titulo = "CLUB ALWAYS READY PLANTEL 2020";
            subtitulo = "Este jueves 16 de Enero, en el Estadio Municipal de El Alto presentamos nuestro plantel millonario 2020, estos son nuestros guerreros que afrontarán la Copa Sudamericana y el torneo local. En esta celebración se jugó un partido amistoso contra el plantel de Nacional Potosí donde el equipo millonario se llevó la victoria por 2 a 0";
            imagen1 = "Noti3A";
            imagen2 = "Noti3B";
            imagen3 = "Noti3C";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup4(object sender, EventArgs e)
        {
            titulo = "PRUEBA DE TALENTOS";
            subtitulo = "En el primer día de la prueba de talentos en Villa Ingenio hubo una gran cantidad de jóvenes que asistieron para demostrar su potencial. Este jueves 9 continuarán las pruebas con los nacidos en 2000, 2001, 2002 y 2003 y viernes 10 con los nacidos en 2005, 2006, 2007 a partir de las 11:00 am. No pierdas tu oportunidad!";
            imagen1 = "Noti4A";
            imagen2 = "Noti4B";
            imagen3 = "Noti4C";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
        private async void BotonPopup5(object sender, EventArgs e)
        {
            titulo = "ALWAYS READY VS SPORT BOYS TORNEO CLAUSURA 2019";
            subtitulo = "Te mostramos algunas imágenes del partido que disputamos contra Sport Boys";
            imagen1 = "Noti5A";
            imagen2 = "Noti5B";
            imagen3 = "Noti5C";
            // Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopUp(titulo, subtitulo, imagen1, imagen2, imagen3));
            metodosPop();
        }
    }
}