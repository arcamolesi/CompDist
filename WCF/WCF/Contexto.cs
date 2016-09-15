using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace WCF
{
    public class Contexto:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public Contexto() : base("COMPD2016") { }
    }
}