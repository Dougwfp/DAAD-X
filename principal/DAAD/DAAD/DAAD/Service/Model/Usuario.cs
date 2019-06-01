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
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public int enderco { get; set; }
        public int gps { get; set; }
        public string sexo { get; set; }
        public string cargo { get; set; }
    }
}
