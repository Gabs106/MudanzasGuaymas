﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MudanzasGuaymasWeb.SrvPreCita {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="preCita", Namespace="http://schemas.datacontract.org/2004/07/MudanzasGuaymasServices.Entity")]
    [System.SerializableAttribute()]
    public partial class preCita : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> AceptadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LatitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LongitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> TerminadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> TotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> id_PaqueteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> id_usuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Aceptado {
            get {
                return this.AceptadoField;
            }
            set {
                if ((this.AceptadoField.Equals(value) != true)) {
                    this.AceptadoField = value;
                    this.RaisePropertyChanged("Aceptado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Detalle {
            get {
                return this.DetalleField;
            }
            set {
                if ((object.ReferenceEquals(this.DetalleField, value) != true)) {
                    this.DetalleField = value;
                    this.RaisePropertyChanged("Detalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Latitud {
            get {
                return this.LatitudField;
            }
            set {
                if ((object.ReferenceEquals(this.LatitudField, value) != true)) {
                    this.LatitudField = value;
                    this.RaisePropertyChanged("Latitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Longitud {
            get {
                return this.LongitudField;
            }
            set {
                if ((object.ReferenceEquals(this.LongitudField, value) != true)) {
                    this.LongitudField = value;
                    this.RaisePropertyChanged("Longitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Terminado {
            get {
                return this.TerminadoField;
            }
            set {
                if ((this.TerminadoField.Equals(value) != true)) {
                    this.TerminadoField = value;
                    this.RaisePropertyChanged("Terminado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> id_Paquete {
            get {
                return this.id_PaqueteField;
            }
            set {
                if ((this.id_PaqueteField.Equals(value) != true)) {
                    this.id_PaqueteField = value;
                    this.RaisePropertyChanged("id_Paquete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> id_usuario {
            get {
                return this.id_usuarioField;
            }
            set {
                if ((this.id_usuarioField.Equals(value) != true)) {
                    this.id_usuarioField = value;
                    this.RaisePropertyChanged("id_usuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SrvPreCita.ISrvPreCita")]
    public interface ISrvPreCita {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/Insertar", ReplyAction="http://tempuri.org/ISrvPreCita/InsertarResponse")]
        bool Insertar(MudanzasGuaymasWeb.SrvPreCita.preCita preCita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/Insertar", ReplyAction="http://tempuri.org/ISrvPreCita/InsertarResponse")]
        System.Threading.Tasks.Task<bool> InsertarAsync(MudanzasGuaymasWeb.SrvPreCita.preCita preCita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/Editar", ReplyAction="http://tempuri.org/ISrvPreCita/EditarResponse")]
        void Editar(MudanzasGuaymasWeb.SrvPreCita.preCita preCita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/Editar", ReplyAction="http://tempuri.org/ISrvPreCita/EditarResponse")]
        System.Threading.Tasks.Task EditarAsync(MudanzasGuaymasWeb.SrvPreCita.preCita preCita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/Eliminar", ReplyAction="http://tempuri.org/ISrvPreCita/EliminarResponse")]
        bool Eliminar(MudanzasGuaymasWeb.SrvPreCita.preCita preCita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/Eliminar", ReplyAction="http://tempuri.org/ISrvPreCita/EliminarResponse")]
        System.Threading.Tasks.Task<bool> EliminarAsync(MudanzasGuaymasWeb.SrvPreCita.preCita preCita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarTodos", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarTodosResponse")]
        MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarTodos", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarTodosResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarPorUsuario", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarPorUsuarioResponse")]
        MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarPorUsuario(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarPorUsuario", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarPorUsuarioResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarPorUsuarioAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarPorId", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarPorIdResponse")]
        MudanzasGuaymasWeb.SrvPreCita.preCita ConsultarPorId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarPorId", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarPorIdResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita> ConsultarPorIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarPendientes", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarPendientesResponse")]
        MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarPendientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarPendientes", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarPendientesResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarPendientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarAceptadas", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarAceptadasResponse")]
        MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarAceptadas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPreCita/ConsultarAceptadas", ReplyAction="http://tempuri.org/ISrvPreCita/ConsultarAceptadasResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarAceptadasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISrvPreCitaChannel : MudanzasGuaymasWeb.SrvPreCita.ISrvPreCita, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SrvPreCitaClient : System.ServiceModel.ClientBase<MudanzasGuaymasWeb.SrvPreCita.ISrvPreCita>, MudanzasGuaymasWeb.SrvPreCita.ISrvPreCita {
        
        public SrvPreCitaClient() {
        }
        
        public SrvPreCitaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SrvPreCitaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SrvPreCitaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SrvPreCitaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Insertar(MudanzasGuaymasWeb.SrvPreCita.preCita preCita) {
            return base.Channel.Insertar(preCita);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarAsync(MudanzasGuaymasWeb.SrvPreCita.preCita preCita) {
            return base.Channel.InsertarAsync(preCita);
        }
        
        public void Editar(MudanzasGuaymasWeb.SrvPreCita.preCita preCita) {
            base.Channel.Editar(preCita);
        }
        
        public System.Threading.Tasks.Task EditarAsync(MudanzasGuaymasWeb.SrvPreCita.preCita preCita) {
            return base.Channel.EditarAsync(preCita);
        }
        
        public bool Eliminar(MudanzasGuaymasWeb.SrvPreCita.preCita preCita) {
            return base.Channel.Eliminar(preCita);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(MudanzasGuaymasWeb.SrvPreCita.preCita preCita) {
            return base.Channel.EliminarAsync(preCita);
        }
        
        public MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarTodos() {
            return base.Channel.ConsultarTodos();
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarTodosAsync() {
            return base.Channel.ConsultarTodosAsync();
        }
        
        public MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarPorUsuario(string id) {
            return base.Channel.ConsultarPorUsuario(id);
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarPorUsuarioAsync(string id) {
            return base.Channel.ConsultarPorUsuarioAsync(id);
        }
        
        public MudanzasGuaymasWeb.SrvPreCita.preCita ConsultarPorId(string id) {
            return base.Channel.ConsultarPorId(id);
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita> ConsultarPorIdAsync(string id) {
            return base.Channel.ConsultarPorIdAsync(id);
        }
        
        public MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarPendientes() {
            return base.Channel.ConsultarPendientes();
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarPendientesAsync() {
            return base.Channel.ConsultarPendientesAsync();
        }
        
        public MudanzasGuaymasWeb.SrvPreCita.preCita[] ConsultarAceptadas() {
            return base.Channel.ConsultarAceptadas();
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPreCita.preCita[]> ConsultarAceptadasAsync() {
            return base.Channel.ConsultarAceptadasAsync();
        }
    }
}
