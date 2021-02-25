using System;
using Persistencia.Contexts;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.DAL.Tabelas
{
    class CategoriaDAL
    {
            private EFContext context = new EFContext();
            public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
            {
                return context.Categorias.OrderBy(b => b.Nome);
            }
    }
}
