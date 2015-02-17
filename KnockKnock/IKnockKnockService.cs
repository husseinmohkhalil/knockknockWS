using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KnockKnock
{

    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    //[System.Runtime.Serialization.DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    //public enum TriangleType : int
    //{

    //    [System.Runtime.Serialization.EnumMemberAttribute()]
    //    Error = 0,

    //    [System.Runtime.Serialization.EnumMemberAttribute()]
    //    Equilateral = 1,

    //    [System.Runtime.Serialization.EnumMemberAttribute()]
    //    Isosceles = 2,

    //    [System.Runtime.Serialization.EnumMemberAttribute()]
    //    Scalene = 3,
    //}

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net", ConfigurationName = "RedPillRefrance.IRedPill")]
    public interface IKnockKnockService 
    {


        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        long FibonacciNumber(long n);

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        string ReverseWords(string s);

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        KnockKnock.RedPillRefrance.TriangleType WhatShapeIsThis(int a, int b, int c);
        //KnockKnock.RedPillService.TriangleType WhatShapeIsThis(int a, int b, int c);

        // TODO: Add your service operations here
    }



}
