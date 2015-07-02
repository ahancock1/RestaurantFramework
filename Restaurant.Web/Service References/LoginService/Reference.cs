﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.Web.LoginService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Entity", Namespace="http://schemas.datacontract.org/2004/07/Restaurant.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Restaurant.Web.LoginService.User))]
    public partial class Entity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime LastUpdatedk__BackingFieldField;
        
        private Restaurant.Web.LoginService.EntityState entityStateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<LastUpdated>k__BackingField", IsRequired=true)]
        public System.DateTime LastUpdatedk__BackingField {
            get {
                return this.LastUpdatedk__BackingFieldField;
            }
            set {
                if ((this.LastUpdatedk__BackingFieldField.Equals(value) != true)) {
                    this.LastUpdatedk__BackingFieldField = value;
                    this.RaisePropertyChanged("LastUpdatedk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Restaurant.Web.LoginService.EntityState entityState {
            get {
                return this.entityStateField;
            }
            set {
                if ((this.entityStateField.Equals(value) != true)) {
                    this.entityStateField = value;
                    this.RaisePropertyChanged("entityState");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Restaurant.Data")]
    [System.SerializableAttribute()]
    public partial class User : Restaurant.Web.LoginService.Entity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateHiredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateHired {
            get {
                return this.DateHiredField;
            }
            set {
                if ((this.DateHiredField.Equals(value) != true)) {
                    this.DateHiredField = value;
                    this.RaisePropertyChanged("DateHired");
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityState", Namespace="http://schemas.datacontract.org/2004/07/Restaurant.Data")]
    public enum EntityState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unchanged = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Added = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Modified = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deleted = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginService.ILoginService")]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Register", ReplyAction="http://tempuri.org/ILoginService/RegisterResponse")]
        bool Register(Restaurant.Web.LoginService.User member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Register", ReplyAction="http://tempuri.org/ILoginService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(Restaurant.Web.LoginService.User member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Login", ReplyAction="http://tempuri.org/ILoginService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Login", ReplyAction="http://tempuri.org/ILoginService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/GetUser", ReplyAction="http://tempuri.org/ILoginService/GetUserResponse")]
        Restaurant.Web.LoginService.User GetUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/GetUser", ReplyAction="http://tempuri.org/ILoginService/GetUserResponse")]
        System.Threading.Tasks.Task<Restaurant.Web.LoginService.User> GetUserAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : Restaurant.Web.LoginService.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<Restaurant.Web.LoginService.ILoginService>, Restaurant.Web.LoginService.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Register(Restaurant.Web.LoginService.User member) {
            return base.Channel.Register(member);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(Restaurant.Web.LoginService.User member) {
            return base.Channel.RegisterAsync(member);
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public Restaurant.Web.LoginService.User GetUser(string username, string password) {
            return base.Channel.GetUser(username, password);
        }
        
        public System.Threading.Tasks.Task<Restaurant.Web.LoginService.User> GetUserAsync(string username, string password) {
            return base.Channel.GetUserAsync(username, password);
        }
    }
}
