﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityStream.HttpMessageSigning
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="helloRequest", Namespace="http://learnwebservices.com/services/hello")]
    public partial class helloRequest : object
    {
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="helloResponse", Namespace="http://learnwebservices.com/services/hello")]
    public partial class helloResponse : object
    {
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://learnwebservices.com/services/hello", ConfigurationName="HttpSigning.HelloEndpoint")]
    public interface HelloEndpoint
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<IdentityStream.HttpMessageSigning.SayHelloResponse> SayHelloAsync(IdentityStream.HttpMessageSigning.SayHello request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SayHello
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SayHello", Namespace="http://learnwebservices.com/services/hello", Order=0)]
        public IdentityStream.HttpMessageSigning.SayHelloBody Body;
        
        public SayHello()
        {
        }
        
        public SayHello(IdentityStream.HttpMessageSigning.SayHelloBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://learnwebservices.com/services/hello")]
    public partial class SayHelloBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public IdentityStream.HttpMessageSigning.helloRequest HelloRequest;
        
        public SayHelloBody()
        {
        }
        
        public SayHelloBody(IdentityStream.HttpMessageSigning.helloRequest HelloRequest)
        {
            this.HelloRequest = HelloRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SayHelloResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SayHelloResponse", Namespace="http://learnwebservices.com/services/hello", Order=0)]
        public IdentityStream.HttpMessageSigning.SayHelloResponseBody Body;
        
        public SayHelloResponse()
        {
        }
        
        public SayHelloResponse(IdentityStream.HttpMessageSigning.SayHelloResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://learnwebservices.com/services/hello")]
    public partial class SayHelloResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public IdentityStream.HttpMessageSigning.helloResponse HelloResponse;
        
        public SayHelloResponseBody()
        {
        }
        
        public SayHelloResponseBody(IdentityStream.HttpMessageSigning.helloResponse HelloResponse)
        {
            this.HelloResponse = HelloResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface HelloEndpointChannel : IdentityStream.HttpMessageSigning.HelloEndpoint, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class HelloEndpointClient : System.ServiceModel.ClientBase<IdentityStream.HttpMessageSigning.HelloEndpoint>, IdentityStream.HttpMessageSigning.HelloEndpoint
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HelloEndpointClient() : 
                base(HelloEndpointClient.GetDefaultBinding(), HelloEndpointClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.HelloEndpointPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloEndpointClient(EndpointConfiguration endpointConfiguration) : 
                base(HelloEndpointClient.GetBindingForEndpoint(endpointConfiguration), HelloEndpointClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloEndpointClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HelloEndpointClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloEndpointClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HelloEndpointClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloEndpointClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IdentityStream.HttpMessageSigning.SayHelloResponse> IdentityStream.HttpMessageSigning.HelloEndpoint.SayHelloAsync(IdentityStream.HttpMessageSigning.SayHello request)
        {
            return base.Channel.SayHelloAsync(request);
        }
        
        public System.Threading.Tasks.Task<IdentityStream.HttpMessageSigning.SayHelloResponse> SayHelloAsync(IdentityStream.HttpMessageSigning.helloRequest HelloRequest)
        {
            IdentityStream.HttpMessageSigning.SayHello inValue = new IdentityStream.HttpMessageSigning.SayHello();
            inValue.Body = new IdentityStream.HttpMessageSigning.SayHelloBody();
            inValue.Body.HelloRequest = HelloRequest;
            return ((IdentityStream.HttpMessageSigning.HelloEndpoint)(this)).SayHelloAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HelloEndpointPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HelloEndpointPort))
            {
                return new System.ServiceModel.EndpointAddress("http://www.learnwebservices.com/services/hello");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return HelloEndpointClient.GetBindingForEndpoint(EndpointConfiguration.HelloEndpointPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return HelloEndpointClient.GetEndpointAddress(EndpointConfiguration.HelloEndpointPort);
        }
        
        public enum EndpointConfiguration
        {
            
            HelloEndpointPort,
        }
    }
}
