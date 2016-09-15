using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema; 

namespace WCF
{
    [Table("Produtos")]
    public class Produto
    {
        
        public int id { get; set; }
        public string descricao { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }
    }
}