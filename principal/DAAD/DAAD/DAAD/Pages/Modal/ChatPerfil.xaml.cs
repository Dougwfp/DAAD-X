﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAAD.Pages.Modal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatPerfil : ContentPage
	{
		public ChatPerfil ()
		{
			InitializeComponent ();
		}
        private void FecharModal(object sender, EventArgs arsg)
        {
            Navigation.PopModalAsync();
        }
    }
}