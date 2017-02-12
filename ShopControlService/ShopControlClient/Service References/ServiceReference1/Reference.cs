﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopControlClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientCatalog", Namespace="http://schemas.datacontract.org/2004/07/ShopControlService")]
    [System.SerializableAttribute()]
    public partial class ClientCatalog : ShopControlClient.ServiceReference1.EntityId {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DiscountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TotalSumField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CardNumber {
            get {
                return this.CardNumberField;
            }
            set {
                if ((this.CardNumberField.Equals(value) != true)) {
                    this.CardNumberField = value;
                    this.RaisePropertyChanged("CardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripton {
            get {
                return this.DescriptonField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptonField, value) != true)) {
                    this.DescriptonField = value;
                    this.RaisePropertyChanged("Descripton");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Discount {
            get {
                return this.DiscountField;
            }
            set {
                if ((this.DiscountField.Equals(value) != true)) {
                    this.DiscountField = value;
                    this.RaisePropertyChanged("Discount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
        public float TotalSum {
            get {
                return this.TotalSumField;
            }
            set {
                if ((this.TotalSumField.Equals(value) != true)) {
                    this.TotalSumField = value;
                    this.RaisePropertyChanged("TotalSum");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityId", Namespace="http://schemas.datacontract.org/2004/07/ShopControlService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ShopControlClient.ServiceReference1.ClientCatalog))]
    public partial class EntityId : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddNewClient", ReplyAction="http://tempuri.org/IService/AddNewClientResponse")]
        void AddNewClient(string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddNewClient", ReplyAction="http://tempuri.org/IService/AddNewClientResponse")]
        System.Threading.Tasks.Task AddNewClientAsync(string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ClientCatalogList", ReplyAction="http://tempuri.org/IService/ClientCatalogListResponse")]
        ShopControlClient.ServiceReference1.ClientCatalog[] ClientCatalogList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ClientCatalogList", ReplyAction="http://tempuri.org/IService/ClientCatalogListResponse")]
        System.Threading.Tasks.Task<ShopControlClient.ServiceReference1.ClientCatalog[]> ClientCatalogListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateClient", ReplyAction="http://tempuri.org/IService/UpdateClientResponse")]
        void UpdateClient(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateClient", ReplyAction="http://tempuri.org/IService/UpdateClientResponse")]
        System.Threading.Tasks.Task UpdateClientAsync(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FindClientById", ReplyAction="http://tempuri.org/IService/FindClientByIdResponse")]
        ShopControlClient.ServiceReference1.ClientCatalog FindClientById(int _id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FindClientById", ReplyAction="http://tempuri.org/IService/FindClientByIdResponse")]
        System.Threading.Tasks.Task<ShopControlClient.ServiceReference1.ClientCatalog> FindClientByIdAsync(int _id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteClient", ReplyAction="http://tempuri.org/IService/DeleteClientResponse")]
        void DeleteClient(int _id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteClient", ReplyAction="http://tempuri.org/IService/DeleteClientResponse")]
        System.Threading.Tasks.Task DeleteClientAsync(int _id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ShopControlClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ShopControlClient.ServiceReference1.IService>, ShopControlClient.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddNewClient(string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl) {
            base.Channel.AddNewClient(NameCl, DescriptionCl, DiscountCl, CardNumberCl, PhoneNumberCl, BirthDateCl);
        }
        
        public System.Threading.Tasks.Task AddNewClientAsync(string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl) {
            return base.Channel.AddNewClientAsync(NameCl, DescriptionCl, DiscountCl, CardNumberCl, PhoneNumberCl, BirthDateCl);
        }
        
        public ShopControlClient.ServiceReference1.ClientCatalog[] ClientCatalogList() {
            return base.Channel.ClientCatalogList();
        }
        
        public System.Threading.Tasks.Task<ShopControlClient.ServiceReference1.ClientCatalog[]> ClientCatalogListAsync() {
            return base.Channel.ClientCatalogListAsync();
        }
        
        public void UpdateClient(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl) {
            base.Channel.UpdateClient(IdCl, NameCl, DescriptionCl, DiscountCl, CardNumberCl, PhoneNumberCl, BirthDateCl);
        }
        
        public System.Threading.Tasks.Task UpdateClientAsync(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, System.DateTime BirthDateCl) {
            return base.Channel.UpdateClientAsync(IdCl, NameCl, DescriptionCl, DiscountCl, CardNumberCl, PhoneNumberCl, BirthDateCl);
        }
        
        public ShopControlClient.ServiceReference1.ClientCatalog FindClientById(int _id) {
            return base.Channel.FindClientById(_id);
        }
        
        public System.Threading.Tasks.Task<ShopControlClient.ServiceReference1.ClientCatalog> FindClientByIdAsync(int _id) {
            return base.Channel.FindClientByIdAsync(_id);
        }
        
        public void DeleteClient(int _id) {
            base.Channel.DeleteClient(_id);
        }
        
        public System.Threading.Tasks.Task DeleteClientAsync(int _id) {
            return base.Channel.DeleteClientAsync(_id);
        }
    }
}
