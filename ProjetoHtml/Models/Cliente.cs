using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoHtml.Models
{
    public class Cliente
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int Nacionalidade { get; set; }
    }
}