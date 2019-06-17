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
	public partial class Depoimentos : ContentPage
	{
		public Depoimentos ()
		{
			InitializeComponent ();

            mde.Completed += delegate (object sender, EventArgs args)
            {
                mdl.Text = mde.Text;
            };

            /*mde.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                mdl.Text = args.NewTextValue;
            };*/
        }
	}
}