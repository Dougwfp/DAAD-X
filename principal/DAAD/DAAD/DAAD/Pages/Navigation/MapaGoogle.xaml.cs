using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DAAD.Service;
using Xamarin.Essentials;

namespace DAAD.Pages.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapaGoogle : ContentPage
	{
		public MapaGoogle ()
		{
			InitializeComponent ();

		}

        public void GoPagina(object sender, EventArgs args)
        {
            Navegador.Source = "http://www." + EnderecoSite.Text;
            //GPSServico.HorVer = "";
        }

        public void GoVoltar(object sender, EventArgs args)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }

        public void GoProximo(object sender, EventArgs args)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        public void ActionCarregando(object sender, EventArgs args)
        {
            lblStatus.Text = "Carregando...";
        }

        public void ActionCarregado(object sender, EventArgs args)
        {
            lblStatus.Text = "Finalizado.";
        }        
    }
}