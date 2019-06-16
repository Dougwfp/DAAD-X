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
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent ();
		}
        private void IrParaSobre(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Sobre());

        }
        private void IrParaCep(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Navigation.Cep());

        }

        private void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal.ContaEdiReg());

        }
    }
}