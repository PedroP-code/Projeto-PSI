using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationTII.Areas.Seguranca.Data.SegurancaViewModels
{
    public class PapelEditModel
    {
        public Papel Papel { get; set; }
        public IEnumerable<Usuario> Membros { get; set; }
        public IEnumerable<Usuario> NaoMembros { get; set; }
    }
}