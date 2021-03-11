using Modelo.Cadastro;
using Persistencia.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Persistencia.DAL.Cadastro
{
    public class FabricanteDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return context.Fabricantes.OrderBy(b => b.Nome);
        }
    }
}
