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
        private List<string> tarLista;

		public Tarefa ()
		{
			InitializeComponent ();

            
            tarLista = new List<string>();
            tarLista.Add("exercicios fisicos - tarefa1");
            tarLista.Add("respirar fundo - tarefa2");
            tarLista.Add("conversar com outras pessoas - tarefa3");
            tarLista.Add("distrair a cabeça com algo que gosta - tarefa4");
            tarLista.Add("se alimentar bem - tarefa5");
            tarLista.Add("dormir direito - tarefa6");
            tarLista.Add("dar atençao as coisas boas da vida - tarefa7");
            tarLista.Add("nao se importar com a opiniao dos outros - tarefa8");

            Preencher(tarLista);

        }
        private void ModalFazer(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal.TarefaFazer());
        }
        private void ModalInfo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Navigation.TarefaInfo());

        }
        /*private void PesquisarBotao(object sender, EventArgs args) //para funcionar só usando o botao de pesquisar.
        {
            var resultado = tarLista.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<string>();
            Preencher(resultado);

        }*/
        private void Pesquisar(object sender, TextChangedEventArgs args) //funciona direto sem precisar apertar o botao.
        {
            var resultado = tarLista.Where(a => a.Contains(args.NewTextValue)).ToList<string>();
            Preencher(resultado);

        }       
        private void Preencher(List<string> lista)
        {
            resultado.Children.Clear();
            foreach (var tar in lista)
            {
                resultado.Children.Add(new Label { Text = tar });
            }
        }
    }
}