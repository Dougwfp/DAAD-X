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
	public partial class Conta : ContentPage
	{
		public Conta ()
		{
			InitializeComponent ();
		}
        private void ModalEdiReg(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal.ContaEdiReg());
        }
    }
}