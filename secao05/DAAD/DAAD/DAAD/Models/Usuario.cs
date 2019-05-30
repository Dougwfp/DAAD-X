using System;
using System.Collections.Generic;
using System.Text;

namespace DAAD.Models
{
    class Usuario
    {
        public int id { get; set; }
        public int login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public int telefone { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string funçcao { get; set; }
        public string logado { get; set; }
        public int idTarefa { get; set; }

    }
}
