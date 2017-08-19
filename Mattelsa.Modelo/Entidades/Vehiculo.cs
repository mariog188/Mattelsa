using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattelsa.Modelo
{
    public class Vehiculo
    {
        [DbColumn(IsPrimary = true)]
        public string Placa { get; set; }
        [DbColumn]
        public string Cilindraje { get; set; }
        [DbColumn]
        public Int64 Tiempos { get; set; }
        [DbColumn]
        public string Modelo { get; set; }
        [DbColumn]
        public Int64 Puertas { get; set; }
        [DbColumn]
        public byte[] Fotografia { get; set; }
        [DbColumn]
        public Int64 CedulaEmpleado { get; set; }
        [DbColumn]
        public Int64 IdTipoVehiculo { get; set; }
    }
}
