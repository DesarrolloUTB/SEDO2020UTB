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
    public partial class MenuHistoria : ContentPage
    {
        public MenuHistoria()
        {
            InitializeComponent();
            List<string> historia = new List<string>()
                {
                    "historia1.jpg",
                    "historia2.jpg",
                    "historia3.jpg",
                    "historia4.jpg",
                    "historia5.jpg",
                    "historia7.jpg",
                };
            listViewHistoria.ItemsSource = historia;
        }
    }
}