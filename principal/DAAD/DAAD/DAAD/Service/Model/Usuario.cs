using System;
using System.Collections.Generic;
using System.Text;

namespace DAAD.Service.Model
{
    class Usuario
    {
        public int id { get; set; }
        public int idTarefa { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public bool presente { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public DateTime nacimento { get; set; }
        public DateTime inicioConta { get; set; }
        public DateTime logadopelaultimavez { get; set; }
        public DateTime deslogadopelaultimavez { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string gps { get; set; }
        public string sexo { get; set; }
        public string cargo { get; set; }
    }
}
