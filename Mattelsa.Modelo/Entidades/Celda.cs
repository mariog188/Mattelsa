using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattelsa.Modelo
{
    public class Celda
    {
        [DbColumn(IsPrimary = true)]
        public Int64 Id { get; set; }
        [DbColumn]
        public string SitioParqueo { get; set; }
        [DbColumn(Convert = true)]
        public System.DateTime FechaHoraIngreso { get; set; }
        [DbColumn]
        public string PlacaVehiculo { get; set; }
        [DbColumn]
        public string Cedula { get; set; }
    }
}
