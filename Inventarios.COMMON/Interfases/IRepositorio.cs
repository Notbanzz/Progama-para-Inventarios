using Inventarios.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios.COMMON.Interfases
{
    public interface IRepositorio<T> where T:Base
    {
        bool Create(T entidad);
        bool Update(string id, T entidadModificada);
        bool Delete(T entidad);
        List<T> Read { get; }
    }
}
