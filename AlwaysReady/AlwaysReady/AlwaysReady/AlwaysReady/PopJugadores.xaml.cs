using Rg.Plugins.Popup.Pages;
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
    public partial class PopJugadores : PopupPage
    {
        public PopJugadores(string foto,string nom, string ed, string nac)
        {
            InitializeComponent();
            fotojug.Source = foto;
            nombre.Text = nom;
            edad.Text = ed;
            nacimiento.Text = nac;
        }
    }
}