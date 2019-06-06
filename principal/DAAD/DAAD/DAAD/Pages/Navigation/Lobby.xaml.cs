using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAAD.Pages.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lobby : ContentPage
	{
		public Lobby ()
		{
			InitializeComponent ();
		}
        private void IrParaSobre(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Sobre());
            
        }
        private void IrParaCep(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cep());

        }

        private void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());

        }
    }
}