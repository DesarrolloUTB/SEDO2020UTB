using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;

namespace AlwaysReady
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    //// by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();

            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetBarItemColor(Color.White);
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetBarSelectedItemColor(Color.DarkRed);

            //BarTextColor = Color.White;
           
        }
        
    }
}
