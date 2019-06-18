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
	public partial class Mapa : ContentPage
	{
		public Mapa ()
		{
			InitializeComponent ();
		}
        private void NavGoogleMaps(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Navigation.MapaGoogle());

        }
        private void NavCEP(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Navigation.Cep());

        }
        private void RotaGoogleMaps(object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            local.Text = obj.SelectedItem.ToString();
        }

        private void MudarDistancia(object sender, ValueChangedEventArgs args)
        {
            dist.Text = "a distancia maxima esta " + args.NewValue.ToString() + "KM";
        }
    }
}