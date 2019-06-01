using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DAAD.Service.Model;
using DAAD.Service;

namespace DAAD
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            but.Clicked += BuscarCEP;

        }
        private void BuscarCEP(object s, EventArgs args)
        {
            // logica do programa


            // validaçoes

            string cep = ent.Text.Trim();
            Usuario usu = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            lab.Text = string.Format("Endereço: {0}, {1}, {2}", usu.estado, usu.cidade, usu.bairro);

        }
        
    }
}
