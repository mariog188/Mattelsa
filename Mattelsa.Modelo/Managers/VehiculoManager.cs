using Mattelsa.Modelo;
using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mattelsa.Modelo.Managers
{
    public class VehiculoManager : BaseService<Vehiculo>
    {
        public VehiculoManager() : base(Storage.ConnectionString)
        {
        }

        public void Guardar(Vehiculo vehiculo)
        {
            Add(vehiculo);
        }

        public IList<Vehiculo> CargarEmpleado(string cedula)
        {
            var filtroCelda = new Filter<Vehiculo>();
            filtroCelda.Add(item => item.CedulaEmpleado,int.Parse(cedula));
            return Find(filtroCelda).ToList();
        }

        public Vehiculo CargarPlaca(string placa)
        {
            var filtroCelda = new Filter<Vehiculo>();
            filtroCelda.Add(item => item.Placa, placa);
            return Find(filtroCelda).FirstOrDefault();
        }
    }
}