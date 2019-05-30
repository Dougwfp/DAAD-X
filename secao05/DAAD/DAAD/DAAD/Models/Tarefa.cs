using System;
using System.Collections.Generic;
using System.Text;

namespace DAAD.Models
{
    class Tarefa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string texto { get; set; }
        public string resultado { get; set; }
        public int pontuacao { get; set; }
        public int idUsuario { get; set; }
    }
}
