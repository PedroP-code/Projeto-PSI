using PSI_Projeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PSI_Projeto.Context
{
    public class EFContext : DbContext  
    {
        public EFContext () : base("Empresa") {}
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}