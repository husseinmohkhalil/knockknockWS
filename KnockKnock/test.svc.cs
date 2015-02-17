using KnockKnock.RedPillRefrance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KnockKnock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  [ServiceContract]
    public class test  : IRedPill
    {
        public void DoWork()
        {
        }

        [OperationContract(Name = "WhatIsYourToken")]
        public Guid WhatIsYourToken()
        {
            throw new NotImplementedException();
        }

        [OperationContract(Name = "FibonacciNumber")]
        public long FibonacciNumber(long n)
        {
            throw new NotImplementedException();
        }

        [OperationContract(Name = "FibonacciNumberAsync")]
        public System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n)
        {
            throw new NotImplementedException();
        }
        [OperationContract(Name = "WhatShapeIsThis")]
        public RedPillRefrance.TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
        [OperationContract(Name = "WhatShapeIsThisAsync")]
        public System.Threading.Tasks.Task<RedPillRefrance.TriangleType> WhatShapeIsThisAsync(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
        [OperationContract(Name = "ReverseWords")]
        public string ReverseWords(string s)
        {
            throw new NotImplementedException();
        }
        [OperationContract(Name = "ReverseWordsAsync")]
        public System.Threading.Tasks.Task<string> ReverseWordsAsync(string s)
        {
            throw new NotImplementedException();
        }

        [OperationContract(Name = "WhatIsYourTokenAsync")]
        public System.Threading.Tasks.Task<Guid> WhatIsYourTokenAsync()
        {
            throw new NotImplementedException();
        }
    }
}
