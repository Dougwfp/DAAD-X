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

        private void MudarCep(object sender, EventArgs args)
        {
            Detail = new Navigation.Cep();
            IsPresented = false;
        }
        private void MudarMapa(object sender, EventArgs args)
        {

        }
        private void MudarChat(object sender, EventArgs args)
        {

        }
        private void MudarConta(object sender, EventArgs args)
        {

        }
    }
}