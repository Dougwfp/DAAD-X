using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAAD.Service.Controller
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Carregando : ContentPage
	{
		public Carregando ()
		{
			InitializeComponent ();
		}

        private void Modificar(object sender, EventArgs args)
        {
            bar01.Progress = 1;
            bar02.ProgressTo(1, 5000, Easing.Linear);
            bar03.ProgressTo(1, 5000, Easing.SpringIn);
        }

    }
}