using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattelsa.Modelo
{
    public class TipoVehiculo
    {
        [DbColumn(IsPrimary = true)]
        public Int64 Id { get; set; }
        [DbColumn]
        public string Descripcion { get; set; }
    }
}
