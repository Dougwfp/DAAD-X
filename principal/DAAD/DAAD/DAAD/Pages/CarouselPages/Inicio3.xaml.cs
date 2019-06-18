using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAAD.Pages.CarouselPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio3 : ContentPage
    {
        public Inicio3()
        {
            InitializeComponent();
        }
        private void MudarPagina(object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new Master.Principal());
            
        }
        private void MudarPaginaTabbed(object sender, EventArgs args)
        {            
            App.Current.MainPage = new Tabbed.Abas();

        }
        private void MudarPaginaMenu(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.MenuLateral(); 


        }

    }
}