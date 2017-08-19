﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mattelsa.Vista.MattelsaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MattelsaService.IMattelsa")]
    public interface IMattelsa {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/ConfigurarConexion", ReplyAction="http://tempuri.org/IMattelsa/ConfigurarConexionResponse")]
        void ConfigurarConexion(string conexion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/ConfigurarConexion", ReplyAction="http://tempuri.org/IMattelsa/ConfigurarConexionResponse")]
        System.Threading.Tasks.Task ConfigurarConexionAsync(string conexion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/Guardar", ReplyAction="http://tempuri.org/IMattelsa/GuardarResponse")]
        void Guardar(Mattelsa.Modelo.Vehiculo vehiculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/Guardar", ReplyAction="http://tempuri.org/IMattelsa/GuardarResponse")]
        System.Threading.Tasks.Task GuardarAsync(Mattelsa.Modelo.Vehiculo vehiculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarTipo", ReplyAction="http://tempuri.org/IMattelsa/CargarTipoResponse")]
        Mattelsa.Modelo.TipoVehiculo[] CargarTipo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarTipo", ReplyAction="http://tempuri.org/IMattelsa/CargarTipoResponse")]
        System.Threading.Tasks.Task<Mattelsa.Modelo.TipoVehiculo[]> CargarTipoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarEmpleados", ReplyAction="http://tempuri.org/IMattelsa/CargarEmpleadosResponse")]
        Mattelsa.Modelo.Empleado[] CargarEmpleados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarEmpleados", ReplyAction="http://tempuri.org/IMattelsa/CargarEmpleadosResponse")]
        System.Threading.Tasks.Task<Mattelsa.Modelo.Empleado[]> CargarEmpleadosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarEmpleado", ReplyAction="http://tempuri.org/IMattelsa/CargarEmpleadoResponse")]
        Mattelsa.Modelo.Vehiculo[] CargarEmpleado(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarEmpleado", ReplyAction="http://tempuri.org/IMattelsa/CargarEmpleadoResponse")]
        System.Threading.Tasks.Task<Mattelsa.Modelo.Vehiculo[]> CargarEmpleadoAsync(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarPlaca", ReplyAction="http://tempuri.org/IMattelsa/CargarPlacaResponse")]
        Mattelsa.Modelo.Vehiculo CargarPlaca(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarPlaca", ReplyAction="http://tempuri.org/IMattelsa/CargarPlacaResponse")]
        System.Threading.Tasks.Task<Mattelsa.Modelo.Vehiculo> CargarPlacaAsync(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/GuardarCelda", ReplyAction="http://tempuri.org/IMattelsa/GuardarCeldaResponse")]
        void GuardarCelda(Mattelsa.Modelo.Celda celda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/GuardarCelda", ReplyAction="http://tempuri.org/IMattelsa/GuardarCeldaResponse")]
        System.Threading.Tasks.Task GuardarCeldaAsync(Mattelsa.Modelo.Celda celda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarCelda", ReplyAction="http://tempuri.org/IMattelsa/CargarCeldaResponse")]
        Mattelsa.Modelo.Celda[] CargarCelda(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMattelsa/CargarCelda", ReplyAction="http://tempuri.org/IMattelsa/CargarCeldaResponse")]
        System.Threading.Tasks.Task<Mattelsa.Modelo.Celda[]> CargarCeldaAsync(string cedula);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMattelsaChannel : Mattelsa.Vista.MattelsaService.IMattelsa, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MattelsaClient : System.ServiceModel.ClientBase<Mattelsa.Vista.MattelsaService.IMattelsa>, Mattelsa.Vista.MattelsaService.IMattelsa {
        
        public MattelsaClient() {
        }
        
        public MattelsaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MattelsaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MattelsaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MattelsaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ConfigurarConexion(string conexion) {
            base.Channel.ConfigurarConexion(conexion);
        }
        
        public System.Threading.Tasks.Task ConfigurarConexionAsync(string conexion) {
            return base.Channel.ConfigurarConexionAsync(conexion);
        }
        
        public void Guardar(Mattelsa.Modelo.Vehiculo vehiculo) {
            base.Channel.Guardar(vehiculo);
        }
        
        public System.Threading.Tasks.Task GuardarAsync(Mattelsa.Modelo.Vehiculo vehiculo) {
            return base.Channel.GuardarAsync(vehiculo);
        }
        
        public Mattelsa.Modelo.TipoVehiculo[] CargarTipo() {
            return base.Channel.CargarTipo();
        }
        
        public System.Threading.Tasks.Task<Mattelsa.Modelo.TipoVehiculo[]> CargarTipoAsync() {
            return base.Channel.CargarTipoAsync();
        }
        
        public Mattelsa.Modelo.Empleado[] CargarEmpleados() {
            return base.Channel.CargarEmpleados();
        }
        
        public System.Threading.Tasks.Task<Mattelsa.Modelo.Empleado[]> CargarEmpleadosAsync() {
            return base.Channel.CargarEmpleadosAsync();
        }
        
        public Mattelsa.Modelo.Vehiculo[] CargarEmpleado(string cedula) {
            return base.Channel.CargarEmpleado(cedula);
        }
        
        public System.Threading.Tasks.Task<Mattelsa.Modelo.Vehiculo[]> CargarEmpleadoAsync(string cedula) {
            return base.Channel.CargarEmpleadoAsync(cedula);
        }
        
        public Mattelsa.Modelo.Vehiculo CargarPlaca(string placa) {
            return base.Channel.CargarPlaca(placa);
        }
        
        public System.Threading.Tasks.Task<Mattelsa.Modelo.Vehiculo> CargarPlacaAsync(string placa) {
            return base.Channel.CargarPlacaAsync(placa);
        }
        
        public void GuardarCelda(Mattelsa.Modelo.Celda celda) {
            base.Channel.GuardarCelda(celda);
        }
        
        public System.Threading.Tasks.Task GuardarCeldaAsync(Mattelsa.Modelo.Celda celda) {
            return base.Channel.GuardarCeldaAsync(celda);
        }
        
        public Mattelsa.Modelo.Celda[] CargarCelda(string cedula) {
            return base.Channel.CargarCelda(cedula);
        }
        
        public System.Threading.Tasks.Task<Mattelsa.Modelo.Celda[]> CargarCeldaAsync(string cedula) {
            return base.Channel.CargarCeldaAsync(cedula);
        }
    }
}