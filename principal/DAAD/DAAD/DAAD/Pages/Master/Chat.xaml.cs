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
	public partial class Chat : ContentPage
	{
		public Chat ()
		{
			InitializeComponent ();
		}
        private void ModalPerfil(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal.ChatPerfil());
        }
        private void NavSala(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Navigation.ChatSala());

        }
    }
}