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
        public string gps { get; set; }
        public string sexo { get; set; }
        public string cargo { get; set; }
        public string depoimento { get; set; }//criar o modelo proprio
    }
}
