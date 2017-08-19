namespace Mattelsa.Vista.VistaModelo
{
    #region Librerias
    using Mattelsa.Modelo;
    using Mattelsa.Vista.Helpers;
    using Mattelsa.Vista.MattelsaService;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    #endregion

    public class InformeVM : BindableBase
    {
        #region Atributos
        private MattelsaClient mattelsaClient;
        private ObservableCollection<Celda> celdas;
        private string cedula;
        private DateTime fecha;
        private ICommand buscarEmpleado;
        #endregion

        #region Propiedades
        public ObservableCollection<Celda> Celdas
        {
            get { return celdas; }
            set { SetProperty<ObservableCollection<Celda>>(ref celdas, value); }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { SetProperty<DateTime>(ref fecha, value); }
        }

        public ICommand BuscarRegistros { get { return buscarEmpleado; } }
        #endregion

        #region Constructor
        public InformeVM()
        {
            mattelsaClient = new MattelsaClient();
            mattelsaClient.ConfigurarConexion(Storage.ConnectionString);
            buscarEmpleado = new RelayCommand(Buscar);
            Fecha = DateTime.Now;
        }
        #endregion

        #region Metodos
        private void Buscar(object obj)
        {
            celdas = new ObservableCollection<Celda>(mattelsaClient.CargarCelda(cedula));
            if (celdas != null)
            {
                Celdas = new ObservableCollection<Celda>(from item in celdas
                                                         where item.FechaHoraIngreso.Month.Equals(Fecha.Month)
                                                         select item);
            }
        } 
        #endregion
    }
}
