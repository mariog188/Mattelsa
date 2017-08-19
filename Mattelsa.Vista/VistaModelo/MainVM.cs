namespace Mattelsa.Vista.VistaModelo
{
    #region Librerias
    using Mattelsa.Vista.Helpers;
    using Mattelsa.Vista.Vistas;
    using System.Windows.Input; 
    #endregion

    public class MainVM : BindableBase
    {
        #region Atributos
        private readonly ICommand registroVehiculo;
        private readonly ICommand ingresarParqueadero;
        private readonly ICommand informeMensual;
        #endregion

        #region Public
        public ICommand RegistroVehiculo { get { return registroVehiculo; } }
        public ICommand IngresarParqueadero { get { return ingresarParqueadero; } }
        public ICommand InformeMensual { get { return informeMensual; } }
        #endregion

        #region Constructor
        public MainVM()
        {
            registroVehiculo = new RelayCommand(EjecutarRegistroVehiculo);
            ingresarParqueadero = new RelayCommand(EjecutarIngreso);
            informeMensual = new RelayCommand(EjecutarInforme);
        }
        #endregion

        #region Metodos
        private void EjecutarRegistroVehiculo(object obj)
        {
            RegistrarVehiculo registarVehiculo = new RegistrarVehiculo();
            registarVehiculo.ShowDialog();
        }

        private void EjecutarIngreso(object obj)
        {
            IngresarParqueadero ingresarParqueadero = new IngresarParqueadero();
            ingresarParqueadero.ShowDialog();
        }

        private void EjecutarInforme(object obj)
        {
            InformeMensual informe = new InformeMensual();
            informe.ShowDialog();
        } 
        #endregion
    }
}
