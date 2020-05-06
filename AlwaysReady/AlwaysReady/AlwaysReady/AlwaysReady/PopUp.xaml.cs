using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System.Collections.ObjectModel;

namespace AlwaysReady
{ 
    public partial class PopUp : PopupPage
    {
        private ObservableCollection<Spotlight> listOfSpotlight;
        class Spotlight
        {
            public string Thumbnail { get; set; }
        }
        public PopUp( string titu, string subt, string ima1, string ima2, string ima3)
        {
            InitializeComponent();
            titulo.Text = titu;
            subtitulo.Text = subt;
            //imagen1.Source = ima1;
            //imagen2.Source = ima2;
            //imagen3.Source = ima3;
            var item = new Spotlight { Thumbnail = ima1 };
            listOfSpotlight = new ObservableCollection<Spotlight> { item };
            listOfSpotlight.Add(new Spotlight { Thumbnail = ima2 });
            listOfSpotlight.Add(new Spotlight { Thumbnail = ima3 });

            caroselView.ItemsSource = listOfSpotlight;
            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>

            {

                int currentIndex = caroselView.Position;
                int nextIndex = currentIndex < caroselView.ItemsSource.OfType<object>().Count() - 1
                                     ? currentIndex + 1
                                     : 0;
                caroselView.Position = nextIndex;

                return true;
            }));
        }

    }
}