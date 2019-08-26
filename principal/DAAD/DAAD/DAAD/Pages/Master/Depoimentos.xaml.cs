using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DAAD.Service.Model;

namespace DAAD.Pages.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Depoimentos : ContentPage
	{
		public Depoimentos ()
		{
			InitializeComponent ();


            //List<Tabela> listaTabela = Banco.GetListaTabela; //este é um exemplo de como receberia de um banco de dados comum.
            List<Usuario> usuLista = new List<Usuario>();

            usuLista.Add(new Usuario { nome = "aaaaaaa", sexo = "M", depoimento = "depoimento exemplo 1" });
            usuLista.Add(new Usuario { nome = "bbbbbbb", sexo = "M", depoimento = "depoimento exemplo 2" });
            usuLista.Add(new Usuario { nome = "ccccccc", sexo = "M", depoimento = "depoimento exemplo 3" });
            usuLista.Add(new Usuario { nome = "ddddddd", sexo = "F", depoimento = "depoimento exemplo 4" });

            ListaDepo.ItemsSource = usuLista;

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