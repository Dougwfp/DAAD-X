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
        private void MudarAlerta(object sender, ToggledEventArgs args)
        {
            if(args.Value == true)
            {
                lAlert.Text = "Modo Alerta Ativado!! - " + DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                lAlert.Text = "Modo Alerta Desativado."; 
            }
        }
    }
}