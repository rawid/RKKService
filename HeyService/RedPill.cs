﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://KnockKnock.readify.net", ClrNamespace="knockknock.readify.net")]

namespace knockknock.readify.net
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TriangleType", Namespace="http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://KnockKnock.readify.net", ConfigurationName="IRedPill")]
public interface IRedPill
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
    WhatIsYourTokenResponse WhatIsYourToken(WhatIsYourTokenRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
        "Fault", Name="ArgumentOutOfRangeException", Namespace="http://schemas.datacontract.org/2004/07/System")]
    FibonacciNumberResponse FibonacciNumber(FibonacciNumberRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
    WhatShapeIsThisResponse WhatShapeIsThis(WhatShapeIsThisRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
    ReverseWordsResponse ReverseWords(ReverseWordsRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="WhatIsYourToken", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class WhatIsYourTokenRequest
{
    
    public WhatIsYourTokenRequest()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="WhatIsYourTokenResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class WhatIsYourTokenResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public System.Guid WhatIsYourTokenResult;
    
    public WhatIsYourTokenResponse()
    {
    }
    
    public WhatIsYourTokenResponse(System.Guid WhatIsYourTokenResult)
    {
        this.WhatIsYourTokenResult = WhatIsYourTokenResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="FibonacciNumber", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class FibonacciNumberRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public long n;
    
    public FibonacciNumberRequest()
    {
    }
    
    public FibonacciNumberRequest(long n)
    {
        this.n = n;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="FibonacciNumberResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class FibonacciNumberResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public long FibonacciNumberResult;
    
    public FibonacciNumberResponse()
    {
    }
    
    public FibonacciNumberResponse(long FibonacciNumberResult)
    {
        this.FibonacciNumberResult = FibonacciNumberResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="WhatShapeIsThis", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class WhatShapeIsThisRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public int a;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=1)]
    public int b;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=2)]
    public int c;
    
    public WhatShapeIsThisRequest()
    {
    }
    
    public WhatShapeIsThisRequest(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="WhatShapeIsThisResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class WhatShapeIsThisResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public knockknock.readify.net.TriangleType WhatShapeIsThisResult;
    
    public WhatShapeIsThisResponse()
    {
    }
    
    public WhatShapeIsThisResponse(knockknock.readify.net.TriangleType WhatShapeIsThisResult)
    {
        this.WhatShapeIsThisResult = WhatShapeIsThisResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="ReverseWords", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class ReverseWordsRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public string s;
    
    public ReverseWordsRequest()
    {
    }
    
    public ReverseWordsRequest(string s)
    {
        this.s = s;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="ReverseWordsResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
public partial class ReverseWordsResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
    public string ReverseWordsResult;
    
    public ReverseWordsResponse()
    {
    }
    
    public ReverseWordsResponse(string ReverseWordsResult)
    {
        this.ReverseWordsResult = ReverseWordsResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IRedPillChannel : IRedPill, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class RedPillClient : System.ServiceModel.ClientBase<IRedPill>, IRedPill
{
    
    public RedPillClient()
    {
    }
    
    public RedPillClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public RedPillClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RedPillClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RedPillClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public WhatIsYourTokenResponse WhatIsYourToken(WhatIsYourTokenRequest request)
    {
        return base.Channel.WhatIsYourToken(request);
    }
    
    public FibonacciNumberResponse FibonacciNumber(FibonacciNumberRequest request)
    {
        return base.Channel.FibonacciNumber(request);
    }
    
    public WhatShapeIsThisResponse WhatShapeIsThis(WhatShapeIsThisRequest request)
    {
        return base.Channel.WhatShapeIsThis(request);
    }
    
    public ReverseWordsResponse ReverseWords(ReverseWordsRequest request)
    {
        return base.Channel.ReverseWords(request);
    }
}