﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project5.JaredService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JaredService.ISmartHomeServices")]
    public interface ISmartHomeServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/findNearestStore", ReplyAction="http://tempuri.org/ISmartHomeServices/findNearestStoreResponse")]
        string findNearestStore(string storeName, string zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/findNearestStore", ReplyAction="http://tempuri.org/ISmartHomeServices/findNearestStoreResponse")]
        System.Threading.Tasks.Task<string> findNearestStoreAsync(string storeName, string zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/crimedata", ReplyAction="http://tempuri.org/ISmartHomeServices/crimedataResponse")]
        string crimedata(decimal latitude, decimal longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/crimedata", ReplyAction="http://tempuri.org/ISmartHomeServices/crimedataResponse")]
        System.Threading.Tasks.Task<string> crimedataAsync(decimal latitude, decimal longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/addItemToGroceryList", ReplyAction="http://tempuri.org/ISmartHomeServices/addItemToGroceryListResponse")]
        void addItemToGroceryList(string username, string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/addItemToGroceryList", ReplyAction="http://tempuri.org/ISmartHomeServices/addItemToGroceryListResponse")]
        System.Threading.Tasks.Task addItemToGroceryListAsync(string username, string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/getGroceryList", ReplyAction="http://tempuri.org/ISmartHomeServices/getGroceryListResponse")]
        string getGroceryList(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/getGroceryList", ReplyAction="http://tempuri.org/ISmartHomeServices/getGroceryListResponse")]
        System.Threading.Tasks.Task<string> getGroceryListAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/clearGroceryList", ReplyAction="http://tempuri.org/ISmartHomeServices/clearGroceryListResponse")]
        void clearGroceryList(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartHomeServices/clearGroceryList", ReplyAction="http://tempuri.org/ISmartHomeServices/clearGroceryListResponse")]
        System.Threading.Tasks.Task clearGroceryListAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISmartHomeServicesChannel : Project5.JaredService.ISmartHomeServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmartHomeServicesClient : System.ServiceModel.ClientBase<Project5.JaredService.ISmartHomeServices>, Project5.JaredService.ISmartHomeServices {
        
        public SmartHomeServicesClient() {
        }
        
        public SmartHomeServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SmartHomeServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartHomeServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartHomeServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string findNearestStore(string storeName, string zipCode) {
            return base.Channel.findNearestStore(storeName, zipCode);
        }
        
        public System.Threading.Tasks.Task<string> findNearestStoreAsync(string storeName, string zipCode) {
            return base.Channel.findNearestStoreAsync(storeName, zipCode);
        }
        
        public string crimedata(decimal latitude, decimal longitude) {
            return base.Channel.crimedata(latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<string> crimedataAsync(decimal latitude, decimal longitude) {
            return base.Channel.crimedataAsync(latitude, longitude);
        }
        
        public void addItemToGroceryList(string username, string item) {
            base.Channel.addItemToGroceryList(username, item);
        }
        
        public System.Threading.Tasks.Task addItemToGroceryListAsync(string username, string item) {
            return base.Channel.addItemToGroceryListAsync(username, item);
        }
        
        public string getGroceryList(string username) {
            return base.Channel.getGroceryList(username);
        }
        
        public System.Threading.Tasks.Task<string> getGroceryListAsync(string username) {
            return base.Channel.getGroceryListAsync(username);
        }
        
        public void clearGroceryList(string username) {
            base.Channel.clearGroceryList(username);
        }
        
        public System.Threading.Tasks.Task clearGroceryListAsync(string username) {
            return base.Channel.clearGroceryListAsync(username);
        }
    }
}
