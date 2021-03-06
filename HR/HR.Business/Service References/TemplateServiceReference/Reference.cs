﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.Business.TemplateServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TemplateServiceReference.ITemplateServiceV1100")]
    public interface ITemplateServiceV1100 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemplateServiceV1100/CreatePDF", ReplyAction="http://tempuri.org/ITemplateServiceV1100/CreatePDFResponse")]
        byte[] CreatePDF(string jsonString, string templateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemplateServiceV1100/CreatePDF", ReplyAction="http://tempuri.org/ITemplateServiceV1100/CreatePDFResponse")]
        System.Threading.Tasks.Task<byte[]> CreatePDFAsync(string jsonString, string templateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemplateServiceV1100/CreatePDFfromPDFTemplate", ReplyAction="http://tempuri.org/ITemplateServiceV1100/CreatePDFfromPDFTemplateResponse")]
        byte[] CreatePDFfromPDFTemplate(System.Collections.Generic.Dictionary<string, string> formValues, string templateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemplateServiceV1100/CreatePDFfromPDFTemplate", ReplyAction="http://tempuri.org/ITemplateServiceV1100/CreatePDFfromPDFTemplateResponse")]
        System.Threading.Tasks.Task<byte[]> CreatePDFfromPDFTemplateAsync(System.Collections.Generic.Dictionary<string, string> formValues, string templateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemplateServiceV1100/CreateText", ReplyAction="http://tempuri.org/ITemplateServiceV1100/CreateTextResponse")]
        string CreateText(string jsonString, string templateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemplateServiceV1100/CreateText", ReplyAction="http://tempuri.org/ITemplateServiceV1100/CreateTextResponse")]
        System.Threading.Tasks.Task<string> CreateTextAsync(string jsonString, string templateName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITemplateServiceV1100Channel : HR.Business.TemplateServiceReference.ITemplateServiceV1100, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TemplateServiceV1100Client : System.ServiceModel.ClientBase<HR.Business.TemplateServiceReference.ITemplateServiceV1100>, HR.Business.TemplateServiceReference.ITemplateServiceV1100 {
        
        public TemplateServiceV1100Client() {
        }
        
        public TemplateServiceV1100Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TemplateServiceV1100Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemplateServiceV1100Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemplateServiceV1100Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] CreatePDF(string jsonString, string templateName) {
            return base.Channel.CreatePDF(jsonString, templateName);
        }
        
        public System.Threading.Tasks.Task<byte[]> CreatePDFAsync(string jsonString, string templateName) {
            return base.Channel.CreatePDFAsync(jsonString, templateName);
        }
        
        public byte[] CreatePDFfromPDFTemplate(System.Collections.Generic.Dictionary<string, string> formValues, string templateName) {
            return base.Channel.CreatePDFfromPDFTemplate(formValues, templateName);
        }
        
        public System.Threading.Tasks.Task<byte[]> CreatePDFfromPDFTemplateAsync(System.Collections.Generic.Dictionary<string, string> formValues, string templateName) {
            return base.Channel.CreatePDFfromPDFTemplateAsync(formValues, templateName);
        }
        
        public string CreateText(string jsonString, string templateName) {
            return base.Channel.CreateText(jsonString, templateName);
        }
        
        public System.Threading.Tasks.Task<string> CreateTextAsync(string jsonString, string templateName) {
            return base.Channel.CreateTextAsync(jsonString, templateName);
        }
    }
}
