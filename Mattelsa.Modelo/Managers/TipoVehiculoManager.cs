using Mattelsa.Modelo;
using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mattelsa.Modelo.Managers
{
    public class TipoVehiculoManager : BaseService<TipoVehiculo>
    {
        public TipoVehiculoManager() : base(Storage.ConnectionString)
        {

        }

        public IList<TipoVehiculo> Cargar()
        {
            return GetAll();
        }
    }
}