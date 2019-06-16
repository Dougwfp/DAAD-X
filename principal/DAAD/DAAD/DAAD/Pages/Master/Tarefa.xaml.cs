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
	public partial class Tarefa : ContentPage
	{
		public Tarefa ()
		{
			InitializeComponent ();
		}
        private void ModalFazer(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal.TarefaFazer());
        }
        private void ModalInfo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Navigation.TarefaInfo());

        }
    }
}