namespace Mattelsa.Vista.VistaModelo
{
    #region Librerias
    using Mattelsa.Modelo;
    using Mattelsa.Vista.Helpers;
    using Mattelsa.Vista.MattelsaService;
    using Mattelsa.Vista.Vistas;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Threading; 
    #endregion

    public class IngresarParqueaderoVM : BindableBase
    {
        #region Atributos
        private MattelsaClient mattelsaClient;
        private DateTime horaFechaActual;
        private string cedula;
        private string placas;
        private string celda;
        private ICommand buscarEmpleado;
        private ICommand buscarVehiculo;
        private ICommand guardarRegistro;
        private ObservableCollection<Vehiculo> placasDisponibles;
        private Vehiculo placasSeleccionado;
        private VehiculoVM vehiculoVM;
        #endregion

        #region Propiedades
        public VehiculoVM VehiculoVM
        {
            get { return vehiculoVM; }
            set { SetProperty<VehiculoVM>(ref vehiculoVM, value); }
        }

        public DateTime HoraFechaActual
        {
            get { return horaFechaActual; }
            set { SetProperty<DateTime>(ref horaFechaActual, value); }
        }

        public string Cedula
        {
            get { return cedula; }
            set { SetProperty<string>(ref cedula, value); }
        }

        public string Placas
        {
            get { return placas; }
            set { SetProperty<string>(ref placas, value); }
        }

        public string Celda
        {
            get { return celda; }
            set { SetProperty<string>(ref celda, value); }
        }

        public ICommand BuscarEmpleado { get { return buscarEmpleado; } }
        public ICommand BuscarVehiculo { get { return buscarVehiculo; } }
        public ICommand GuardarRegistro { get { return guardarRegistro; } }

        public ObservableCollection<Vehiculo> PlacasDisponibles
        {
            get { return placasDisponibles; }
            set { SetProperty<ObservableCollection<Vehiculo>>(ref placasDisponibles, value); }
        }

        public Vehiculo PlacasSeleccionado
        {
            get { return placasSeleccionado; }
            set
            {
                SetProperty<Vehiculo>(ref placasSeleccionado, value);
                if (placasSeleccionado != null)
                    Placas = PlacasSeleccionado.Placa;
            }
        }
        #endregion

        #region Constructor
        public IngresarParqueaderoVM()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(CambiarHora);
            timer.Start();
            buscarEmpleado = new RelayCommand(BusquedaEmpleado);
            buscarVehiculo = new RelayCommand(BusquedaVehiculo);
            guardarRegistro = new RelayCommand(Guardar);
            mattelsaClient = new MattelsaClient();
            mattelsaClient.ConfigurarConexion(Storage.ConnectionString);

            VehiculoVM = new VehiculoVM();
        }
        #endregion

        #region Metodos
        private void BusquedaEmpleado(object obj)
        {
            PlacasDisponibles = new ObservableCollection<Vehiculo>(mattelsaClient.CargarEmpleado(cedula));
            if (PlacasDisponibles != null)
                PlacasSeleccionado = PlacasDisponibles.FirstOrDefault();
        }

        private void BusquedaVehiculo(object obj)
        {
            Vehiculos vehiculoV = new Vehiculos();
            vehiculoV.DataContext = VehiculoVM;
            VehiculoVM.VehiculoSeleccionado = mattelsaClient.CargarPlaca(placas);
            if (VehiculoVM.VehiculoSeleccionado != null)
            {
                vehiculoV.ShowDialog();
            }
            else
            {
                RegistrarVehiculo registrarNuevo = new RegistrarVehiculo();
                registrarNuevo.ShowDialog();
            }
        }

        private void Guardar(object obj)
        {
            mattelsaClient.GuardarCelda(new Celda() { FechaHoraIngreso = horaFechaActual, PlacaVehiculo = placas, SitioParqueo = celda, Cedula = cedula });
            if (obj is Window)
                (obj as Window).Close();
        }

        private void CambiarHora(object sender, EventArgs e)
        {
            HoraFechaActual = DateTime.Now;
        } 
        #endregion

    }
}
