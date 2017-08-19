using Mattelsa.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Mattelsa.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMattelsa
    {
        [OperationContract]
        void ConfigurarConexion(string conexion);

        [OperationContract]
        void Guardar(Vehiculo vehiculo);

        [OperationContract]
        IList<TipoVehiculo> CargarTipo();

        [OperationContract]
        IList<Empleado> CargarEmpleados();

        [OperationContract]
        IList<Vehiculo> CargarEmpleado(string cedula);

        [OperationContract]
        Vehiculo CargarPlaca(string placa);

        [OperationContract]
        void GuardarCelda(Celda celda);

        [OperationContract]
        IList<Celda> CargarCelda(string cedula);

    }

}
