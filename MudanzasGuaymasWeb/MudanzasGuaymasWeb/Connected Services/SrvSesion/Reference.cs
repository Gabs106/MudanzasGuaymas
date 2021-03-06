﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MudanzasGuaymasWeb.SrvSesion {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/MudanzasGuaymasServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LlaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public string Llave {
            get {
                return this.LlaveField;
            }
            set {
                if ((object.ReferenceEquals(this.LlaveField, value) != true)) {
                    this.LlaveField = value;
                    this.RaisePropertyChanged("Llave");
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SrvSesion.ISrvSesion")]
    public interface ISrvSesion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Encriptar", ReplyAction="http://tempuri.org/ISrvSesion/EncriptarResponse")]
        string Encriptar(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Encriptar", ReplyAction="http://tempuri.org/ISrvSesion/EncriptarResponse")]
        System.Threading.Tasks.Task<string> EncriptarAsync(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Desencriptar", ReplyAction="http://tempuri.org/ISrvSesion/DesencriptarResponse")]
        string Desencriptar(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Desencriptar", ReplyAction="http://tempuri.org/ISrvSesion/DesencriptarResponse")]
        System.Threading.Tasks.Task<string> DesencriptarAsync(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Logout", ReplyAction="http://tempuri.org/ISrvSesion/LogoutResponse")]
        bool Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Logout", ReplyAction="http://tempuri.org/ISrvSesion/LogoutResponse")]
        System.Threading.Tasks.Task<bool> LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Login", ReplyAction="http://tempuri.org/ISrvSesion/LoginResponse")]
        bool Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/Login", ReplyAction="http://tempuri.org/ISrvSesion/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/ConsultarPorEmail", ReplyAction="http://tempuri.org/ISrvSesion/ConsultarPorEmailResponse")]
        MudanzasGuaymasWeb.SrvSesion.Usuario ConsultarPorEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISrvSesion/ConsultarPorEmail", ReplyAction="http://tempuri.org/ISrvSesion/ConsultarPorEmailResponse")]
        System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvSesion.Usuario> ConsultarPorEmailAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISrvSesionChannel : MudanzasGuaymasWeb.SrvSesion.ISrvSesion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SrvSesionClient : System.ServiceModel.ClientBase<MudanzasGuaymasWeb.SrvSesion.ISrvSesion>, MudanzasGuaymasWeb.SrvSesion.ISrvSesion {
        
        public SrvSesionClient() {
        }
        
        public SrvSesionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SrvSesionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SrvSesionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SrvSesionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Encriptar(string password) {
            return base.Channel.Encriptar(password);
        }
        
        public System.Threading.Tasks.Task<string> EncriptarAsync(string password) {
            return base.Channel.EncriptarAsync(password);
        }
        
        public string Desencriptar(string password) {
            return base.Channel.Desencriptar(password);
        }
        
        public System.Threading.Tasks.Task<string> DesencriptarAsync(string password) {
            return base.Channel.DesencriptarAsync(password);
        }
        
        public bool Logout() {
            return base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task<bool> LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public bool Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public MudanzasGuaymasWeb.SrvSesion.Usuario ConsultarPorEmail(string email) {
            return base.Channel.ConsultarPorEmail(email);
        }
        
        public System.Threading.Tasks.Task<MudanzasGuaymasWeb.SrvSesion.Usuario> ConsultarPorEmailAsync(string email) {
            return base.Channel.ConsultarPorEmailAsync(email);
        }
    }
}
