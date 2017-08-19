using Mattelsa.Modelo;
using Mattelsa.Vista.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Mattelsa.Vista.VistaModelo
{
    public class VehiculoVM : BindableBase
    {
        private Vehiculo vehiculoSeleccionado;

        public Vehiculo VehiculoSeleccionado
        {
            get { return vehiculoSeleccionado; }
            set
            {
                SetProperty<Vehiculo>(ref vehiculoSeleccionado, value);
                if (vehiculoSeleccionado != null)
                {
                    CamposVisibles();
                    CargarImagen();
                }
            }
        }

        public bool carroVisible;
        public bool CarroVisible
        {
            get { return carroVisible; }
            set
            {
                SetProperty<bool>(ref carroVisible, value);
            }
        }

        public bool motoVisible;
        public bool MotoVisible
        {
            get { return motoVisible; }
            set
            {
                SetProperty<bool>(ref motoVisible, value);
            }
        }

        private string tipoVehiculo;

        public string TipoVehiculo
        {
            get { return tipoVehiculo; }
            set
            {
                SetProperty<string>(ref tipoVehiculo, value);
            }
        }

        private BitmapImage fotoVehiculo;

        public BitmapImage FotoVehiculo
        {
            get { return fotoVehiculo; }
            set
            {
                SetProperty<BitmapImage>(ref fotoVehiculo, value);
            }
        }


        public VehiculoVM()
        {

        }

        private void CargarImagen()
        {
            using (MemoryStream ms = new MemoryStream(VehiculoSeleccionado.Fotografia))
            {
                try
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    FotoVehiculo = new BitmapImage();
                    FotoVehiculo.BeginInit();
                    FotoVehiculo.StreamSource = ms;
                    FotoVehiculo.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    FotoVehiculo.CacheOption = BitmapCacheOption.OnLoad;
                    FotoVehiculo.UriSource = null;
                    FotoVehiculo.EndInit();
                }
                catch (Exception exc)
                {

                    throw;
                }
            }

        }


        private bool CamposVisibles()
        {
            if (VehiculoSeleccionado.IdTipoVehiculo.Equals(1))
            {
                MotoVisible = true;
                CarroVisible = false;
                TipoVehiculo = "Moto";
            }
            else
            {
                if (VehiculoSeleccionado.IdTipoVehiculo.Equals(2))
                {
                    MotoVisible = false;
                    CarroVisible = true;
                    TipoVehiculo = "Carro";
                }
                else
                {
                    MotoVisible = false;
                    CarroVisible = false;
                    TipoVehiculo = "Bicicleta";
                }
            }
            return false;
        }
    }
}
