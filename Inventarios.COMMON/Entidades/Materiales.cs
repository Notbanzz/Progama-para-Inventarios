using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios.COMMON.Entidades
{
    public class Materiales:Base
    {
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
