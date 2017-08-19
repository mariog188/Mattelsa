using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Mattelsa.Modelo;
using Mattelsa.Modelo.Managers;

namespace Mattelsa.Servicios
{
    public class MattelsaService : IMattelsa
    {
        public void Guardar(Vehiculo vehiculo)
        {
            new VehiculoManager().Guardar(vehiculo);
        }

        public IList<TipoVehiculo> CargarTipo()
        {
            return new TipoVehiculoManager().Cargar();
        }

        public IList<Empleado> CargarEmpleados()
        {
            return new EmpleadoManager().Cargar();
        }

        public IList<Vehiculo> CargarEmpleado(string cedula)
        {
            return new VehiculoManager().CargarEmpleado(cedula);
        }

        public Vehiculo CargarPlaca(string placa)
        {
            return new VehiculoManager().CargarPlaca(placa);
        }

        public void GuardarCelda(Celda celda)
        {
            new CeldaManager().Guardar(celda);
        }

        public IList<Celda> CargarCelda(string cedula)
        {
            return new CeldaManager().Cargar(cedula);
        }

        public void ConfigurarConexion(string conexion)
        {
            Storage.ConnectionString = conexion;
        }
    }
}
