using Inventarios.COMMON.Entidades;
using Inventarios.COMMON.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        public List<Empleado> Read => throw new NotImplementedException();

        public bool Create(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entidadOriginal, Empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
