using Mattelsa.Modelo;
using Mattelsa.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mattelsa.Modelo.Managers
{
    public class CeldaManager : BaseService<Celda>
    {
        List<Celda> celdas;

        public CeldaManager() : base(Storage.ConnectionString)
        {

        }

        public void Guardar(Celda celda)
        {
            Add(celda);
        }

        public IList<Celda> Cargar(string cedula)
        {
            var filtroCelda = new Filter<Celda>();
            filtroCelda.Add(item => item.Cedula, int.Parse(cedula));
            return Find(filtroCelda).ToList();
        }
    }
}