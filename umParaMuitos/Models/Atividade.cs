using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umParaMuitos.Models
{
    public class Atividade
    {
        public int AtividadeID { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime Final { get; set; }
        public string  Descricao { get; set; }
        public string  Local { get; set; }

        public int PessoaID { get; set; }
        public virtual Pessoa Pessoa { get; set; } 

    }
}