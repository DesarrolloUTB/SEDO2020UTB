using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlwaysReady
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopEntradas : PopupPage
    {
        public PopEntradas()
        {
            InitializeComponent();
        }

        public ScaleAnimation Animation { get; internal set; }
    }
}