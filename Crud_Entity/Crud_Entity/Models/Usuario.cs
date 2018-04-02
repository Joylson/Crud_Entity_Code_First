using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Entity.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}