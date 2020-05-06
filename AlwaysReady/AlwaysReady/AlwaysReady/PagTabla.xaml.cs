using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlwaysReady
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagTabla : ContentPage
    {
        private ObservableCollection<RootObject> _rootobj;
        public PagTabla()
        {
            InitializeComponent();

            BindingContext = this;
            var assembly = typeof(PagTabla).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("AlwaysReady.Posiciones.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<RootObject> mylist = JsonConvert.DeserializeObject<List<RootObject>>(json);
                _rootobj = new ObservableCollection<RootObject>(mylist);
                listviewPos.ItemsSource = _rootobj;
            }
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