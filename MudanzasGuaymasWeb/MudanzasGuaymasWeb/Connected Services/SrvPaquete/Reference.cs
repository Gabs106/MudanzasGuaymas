﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MudanzasGuaymasWeb.SrvPaquete {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paquete", Namespace="http://schemas.datacontract.org/2004/07/MudanzasGuaymasServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Paquete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Id_ServicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> MostrarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnidadField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
        public System.Nullable<int> Id_Servicio {
            get {
                return this.Id_ServicioField;
            }
            set {
                if ((this.Id_ServicioField.Equals(value) != true)) {
                    this.Id_ServicioField = value;
                    this.RaisePropertyChanged("Id_Servicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imagen {
            get {
                return this.ImagenField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagenField, value) != true)) {
                    this.ImagenField = value;
                    this.RaisePropertyChanged("Imagen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Mostrar {
            get {
                return this.MostrarField;
            }
            set {
                if ((this.MostrarField.Equals(value) != true)) {
                    this.MostrarField = value;
                    this.RaisePropertyChanged("Mostrar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Unidad {
            get {
                return this.UnidadField;
            }
            set {
                if ((object.ReferenceEquals(this.UnidadField, value) != true)) {
                    this.UnidadField = value;
                    this.RaisePropertyChanged("Unidad");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SrvPaquete.ISrvPaquete")]
    public interface ISrvPaquete {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/Insertar", ReplyAction="http://tempuri.org/ISrvPaquete/InsertarResponse")]
        bool Insertar(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/Insertar", ReplyAction="http://tempuri.org/ISrvPaquete/InsertarResponse")]
        System.Threading.Tasks.Task<bool> InsertarAsync(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/Editar", ReplyAction="http://tempuri.org/ISrvPaquete/EditarResponse")]
        void Editar(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/Editar", ReplyAction="http://tempuri.org/ISrvPaquete/EditarResponse")]
        System.Threading.Tasks.Task EditarAsync(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/Eliminar", ReplyAction="http://tempuri.org/ISrvPaquete/EliminarResponse")]
        bool Eliminar(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/Eliminar", ReplyAction="http://tempuri.org/ISrvPaquete/EliminarResponse")]
        System.Threading.Tasks.Task<bool> EliminarAsync(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/ConsultarTodos", ReplyAction="http://tempuri.org/ISrvPaquete/ConsultarTodosResponse")]
        MudanzasGuaymasWeb.SrvPaquete.Paquete[] ConsultarTodos(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/ConsultarTodos", ReplyAction="http://tempuri.org/ISrvPaquete/ConsultarTodosResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPaquete.Paquete[]> ConsultarTodosAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/ConsultarPorNombre", ReplyAction="http://tempuri.org/ISrvPaquete/ConsultarPorNombreResponse")]
        MudanzasGuaymasWeb.SrvPaquete.Paquete[] ConsultarPorNombre(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/ConsultarPorNombre", ReplyAction="http://tempuri.org/ISrvPaquete/ConsultarPorNombreResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPaquete.Paquete[]> ConsultarPorNombreAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/ConsultarPorId", ReplyAction="http://tempuri.org/ISrvPaquete/ConsultarPorIdResponse")]
        MudanzasGuaymasWeb.SrvPaquete.Paquete ConsultarPorId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvPaquete/ConsultarPorId", ReplyAction="http://tempuri.org/ISrvPaquete/ConsultarPorIdResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPaquete.Paquete> ConsultarPorIdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISrvPaqueteChannel : MudanzasGuaymasWeb.SrvPaquete.ISrvPaquete, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SrvPaqueteClient : System.ServiceModel.ClientBase<MudanzasGuaymasWeb.SrvPaquete.ISrvPaquete>, MudanzasGuaymasWeb.SrvPaquete.ISrvPaquete {
        
        public SrvPaqueteClient() {
        }
        
        public SrvPaqueteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SrvPaqueteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SrvPaqueteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SrvPaqueteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Insertar(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete) {
            return base.Channel.Insertar(paquete);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarAsync(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete) {
            return base.Channel.InsertarAsync(paquete);
        }
        
        public void Editar(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete) {
            base.Channel.Editar(paquete);
        }
        
        public System.Threading.Tasks.Task EditarAsync(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete) {
            return base.Channel.EditarAsync(paquete);
        }
        
        public bool Eliminar(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete) {
            return base.Channel.Eliminar(paquete);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(MudanzasGuaymasWeb.SrvPaquete.Paquete paquete) {
            return base.Channel.EliminarAsync(paquete);
        }
        
        public MudanzasGuaymasWeb.SrvPaquete.Paquete[] ConsultarTodos(string id) {
            return base.Channel.ConsultarTodos(id);
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPaquete.Paquete[]> ConsultarTodosAsync(string id) {
            return base.Channel.ConsultarTodosAsync(id);
        }
        
        public MudanzasGuaymasWeb.SrvPaquete.Paquete[] ConsultarPorNombre(string nombre) {
            return base.Channel.ConsultarPorNombre(nombre);
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPaquete.Paquete[]> ConsultarPorNombreAsync(string nombre) {
            return base.Channel.ConsultarPorNombreAsync(nombre);
        }
        
        public MudanzasGuaymasWeb.SrvPaquete.Paquete ConsultarPorId(string id) {
            return base.Channel.ConsultarPorId(id);
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvPaquete.Paquete> ConsultarPorIdAsync(string id) {
            return base.Channel.ConsultarPorIdAsync(id);
        }
    }
}