namespace Mattelsa.Vista.VistaModelo
{
    #region Librerias
    using Mattelsa.Modelo;
    using Mattelsa.Vista.Entidades;
    using Mattelsa.Vista.Helpers;
    using Mattelsa.Vista.MattelsaService;
    using Microsoft.Win32;
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media.Imaging;
    #endregion

    public class RegistrarVehiculoVM : BindableBase
    {
        #region Atributos
        private TipoVehiculo tipoSeleccionaado;
        private Empleado empleadoSeleccionado;
        private VehiculoUI vehiculo;
        private BitmapImage fotoVehiculo;
        private ICommand subirFoto;
        private bool carroVisible;
        private bool motoVisible;
        private MattelsaClient mattelsaClient;
        private readonly ICommand guardarRegistro;
        #endregion

        #region Propiedades
        public ObservableCollection<TipoVehiculo> TiposVehiculos { get; set; }

        public TipoVehiculo TipoSeleccionado
        {
            get { return tipoSeleccionaado; }

            set
            {
                if (tipoSeleccionaado != value)
                {
                    SetProperty<TipoVehiculo>(ref tipoSeleccionaado, value);
                    CamposVisibles();
                }
            }
        }

        public ObservableCollection<Empleado> Empleados { get; set; }

        public Empleado EmpleadoSeleccionado
        {
            get { return empleadoSeleccionado; }

            set
            {
                if (empleadoSeleccionado != value)
                {
                    SetProperty<Empleado>(ref empleadoSeleccionado, value);
                }
            }
        }

        public VehiculoUI Vehiculo
        {
            get { return vehiculo; }
            set
            {
                if (vehiculo != value)
                {
                    SetProperty<VehiculoUI>(ref vehiculo, value);
                }
            }
        }

        public ICommand SubirFoto { get { return subirFoto; } }

        public BitmapImage FotoVehiculo
        {
            get { return fotoVehiculo; }
            set
            {
                SetProperty<BitmapImage>(ref fotoVehiculo, value);
            }
        }

        public bool CarroVisible
        {
            get { return carroVisible; }
            set
            {
                SetProperty<bool>(ref carroVisible, value);
            }
        }

        public bool MotoVisible
        {
            get { return motoVisible; }
            set
            {
                SetProperty<bool>(ref motoVisible, value);
            }
        }

        public ICommand GuardarRegistro { get { return guardarRegistro; } }
        #endregion

        #region Constructor
        public RegistrarVehiculoVM()
        {
            mattelsaClient = new MattelsaClient();
            mattelsaClient.ConfigurarConexion(Storage.ConnectionString);
            AutoMapper.Mapper.Initialize(item => { item.CreateMap<VehiculoUI, Vehiculo>(); });

            Vehiculo = new VehiculoUI();
            guardarRegistro = new RelayCommand(Guardar);
            TiposVehiculos = new ObservableCollection<TipoVehiculo>(mattelsaClient.CargarTipo());
            TipoSeleccionado = TiposVehiculos.FirstOrDefault();

            Empleados = new ObservableCollection<Empleado>(mattelsaClient.CargarEmpleados());
            empleadoSeleccionado = Empleados.FirstOrDefault();
            subirFoto = new RelayCommand(ObtenerFoto);
        } 
        #endregion

        private void Guardar(object obj)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo = AutoMapper.Mapper.Map<VehiculoUI, Vehiculo>(Vehiculo);
            vehiculo.CedulaEmpleado = EmpleadoSeleccionado.Cedula;
            vehiculo.IdTipoVehiculo = TipoSeleccionado.Id;

            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(fotoVehiculo));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                vehiculo.Fotografia = ms.ToArray();
            }
            mattelsaClient.Guardar(vehiculo);
            Vehiculo = new VehiculoUI();
            FotoVehiculo = new BitmapImage();
            if (obj is Window)
                (obj as Window).Close();
        }

        private void ObtenerFoto(object obj)
        {
            OpenFileDialog file = new OpenFileDialog();
            Nullable<bool> result = file.ShowDialog();
            if (File.Exists(file.FileName))
            {
                FotoVehiculo = new BitmapImage(new Uri(file.FileName, UriKind.Absolute));
            }
        }

        private bool CamposVisibles()
        {
            if (tipoSeleccionaado.Descripcion.Equals("Moto"))
            {
                MotoVisible = true;
                CarroVisible = false;
            }
            else
            {
                if (tipoSeleccionaado.Descripcion.Equals("Carro"))
                {
                    MotoVisible = false;
                    CarroVisible = true;
                }
                else
                {
                    MotoVisible = false;
                    CarroVisible = false;
                }
            }
            return false;
        }



    }
}
