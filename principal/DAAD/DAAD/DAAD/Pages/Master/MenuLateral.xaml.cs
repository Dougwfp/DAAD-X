using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAAD.Pages.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuLateral : MasterDetailPage
    {
		public MenuLateral ()
		{
			InitializeComponent ();
		}

        private void MenuChat(object sender, EventArgs args)
        {
            Detail = new NavigationPage( new Chat());
            IsPresented = false;
        }
        private void MenuConta(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Conta());
            IsPresented = false;
        }
        private void MenuMapa(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Mapa());
            IsPresented = false;
        }
        private void MenuTarefa(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Tarefa());
            IsPresented = false;
        }
        private void MenuPrincipal(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Principal());
            IsPresented = false;
        }
        private void MenuSobre(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;
        }
        private void MenuDepo(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Depoimentos());
            IsPresented = false;
        }
        private void MenuConfig(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Configuracao());
            IsPresented = false;
        }
        private void MenuCarregando(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Service.Controller.Carregando());
            IsPresented = false;
        }
        private void GoToFacebook(object sender, EventArgs args)
        {

        }
        private void GoToInstagram(object sender, EventArgs args)
        {

        }
        private void GoToTwitter(object sender, EventArgs args)
        {

        }
        private void GoToYoutube(object sender, EventArgs args)
        {

        }
    }
}