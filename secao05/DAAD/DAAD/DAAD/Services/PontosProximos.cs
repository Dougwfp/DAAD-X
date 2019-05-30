using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using DAAD.Models;


namespace DAAD.Services
{
    class PontosProximos
    {
        private static string enderecoURL = "https://www.google.com.br/maps/search/Hospitais/";

        public static string BuscarPontosPeloGPS(string gps)
        {
            gps = "@-23.8907151,-46.4295551,14.33z";
            string novoEnderecoURL = string.Format(enderecoURL, gps);

            //WebClient wc = new WebClient(); era para criar uma conexçao online
            //string json = "url com um json nele";
            //string Conteudo = wc.DownloadString(novoEnderecoURL); era para fazer o download de uma pagina URL
            //string converido = JsonConvert.DeserializeObject<string>(Conteudo);
            //return converido;


            return novoEnderecoURL;

        }

    }
}
