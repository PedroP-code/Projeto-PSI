﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI_Projeto.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }

        public long? FabricanteId { get; set; }
        public long? CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}