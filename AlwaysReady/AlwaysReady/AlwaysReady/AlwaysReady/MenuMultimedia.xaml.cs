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
    public partial class MenuMultimedia : ContentPage
    {
        public MenuMultimedia()
        {
            InitializeComponent();
            video1.Source = "https://www.youtube.com/embed/uEx5MK7e_nA";
            video2.Source = "https://www.youtube.com/embed/ZjpTy_Ijeig";
            video3.Source = "https://www.youtube.com/embed/G7gwbmocF0s";
            video4.Source = "https://www.youtube.com/embed/F-VUQZXIJOw";
            video5.Source = "https://www.youtube.com/embed/fxiwdtfksRg";
            video6.Source = "https://www.youtube.com/embed/idBOvo7-_Ow";
        }
    }
}