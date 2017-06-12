using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umParaMuitos.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Atividade> Atividades { get; set; }
    }
}