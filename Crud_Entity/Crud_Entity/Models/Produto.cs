using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Entity.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Qtde { get; set; }
    }
}