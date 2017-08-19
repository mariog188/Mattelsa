using Mattelsa.Modelo;
using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mattelsa.Modelo.Managers
{
    public class EmpleadoManager : BaseService<Empleado>
    {
        public EmpleadoManager() : base(Storage.ConnectionString)
        {

        }

        public IList<Empleado> Cargar()
        {            
            return GetAll();
        }
    }
}