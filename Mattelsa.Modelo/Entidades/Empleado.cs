using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattelsa.Modelo
{
    public  class Empleado
    {
        [DbColumn(IsPrimary = true)]
        public Int64 Cedula { get; set; }
        [DbColumn]
        public string Nombre { get; set; }
        [DbColumn]
        public string Apellido { get; set; }
        [DbColumn]
        public Int64 Edad { get; set; }
    }
}
