using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DAAD.Service.Model;
using DAAD.Service;

namespace DAAD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BuscaCep : ContentPage
	{
		public BuscaCep ()
		{
			InitializeComponent ();

            but.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object s, EventArgs args)
        {
            // logica do programa
            string cep = ent.Text.Trim();

            // validaçoes
            if (isValidCEP(cep))
            {
                try
                {
                    Usuario usu = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (usu != null)
                    {
                        lab.Text = string.Format("Endereço: {0}, {1}, {2}, {3}, {4}", usu.uf, usu.localidade, usu.bairro, usu.logradouro, usu.complemento, usu.cep);

                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço n foi encontrado para o cep informado: " + ent.Text, "OK");
                    }



                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }

            }


        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;
            int novoCEP;
            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres.", "OK");
                valido = false;
            }
            if (!int.TryParse(cep, out novoCEP))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter apenas numeros.", "OK");
                valido = false;
            }

            return valido;
        }

    }
}
