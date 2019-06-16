﻿using System;
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
    }
}