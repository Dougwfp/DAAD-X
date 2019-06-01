using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using DAAD.Service.Model;
using Newtonsoft.Json;

namespace DAAD.Service
{
    class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";//endereço inicial para base de busca, e lembrando que o {0} é para ser subistituido
        private static string MapaURL = "";//endereço inicial para base de busca

        public static Usuario BuscarEnderecoViaCEP(string cep)
        {
            string NovoEderecoURL = string.Format(EnderecoURL, cep);//subistitui o {0} pelo cep que o usuario digitou.

            WebClient wc = new WebClient();//cria um webclient para poder acessar uma pagina na internet.
            string Conteudo = wc.DownloadString(NovoEderecoURL);//baixa o conteudo de uma pagina em formato string.

            Usuario end = JsonConvert.DeserializeObject<Usuario>(Conteudo);

            return end;
        }


    }
}
