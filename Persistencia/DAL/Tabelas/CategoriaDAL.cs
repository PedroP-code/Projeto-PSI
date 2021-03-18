using System;
using Persistencia.Contexts;
using System.Collections.Generic;
using System.Text;
using Modelo.Tabelas;
using System.Linq;
using System.Data.Entity;

namespace Persistencia.DAL.Tabelas
{
    public class CategoriaDAL
    {
        private CategoriaDAL categoriaDal = new CategoriaDAL();
        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return categoriaDal.ObterCategoriasClassificadasPorNome();
        }
        public Categoria ObterCategoriaPorId(long id)
        {
            return categoriaDal.ObterCategoriaPorId(id);
        }
        public void GravarCategoria(Categoria categoria)
        {
            categoriaDal.GravarCategoria(categoria);
        }
        public Categoria EliminarCategoriaPorId(long id)
        {
            return categoriaDal.EliminarCategoriaPorId(id);
        }
    }
}
