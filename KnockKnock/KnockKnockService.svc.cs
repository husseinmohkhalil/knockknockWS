using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KnockKnock
{
    // NOTE: You can use the "Rename" command on t  he "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]

    public class KnockKnockService : IKnockKnockService
    {
        /// <summary>
        /// indecate the value of febunacci series based on its index
        /// </summary>
        /// <param name="n">the index </param>
        /// <returns>
        /// 1) the value of the intem in the nth position 
        /// 2) -1 incase of error
        /// </returns>
        public long FibonacciNumber(long n)
        {
            //case of n=-1 not handeled in original service
            if (n == -1)
            {
                return -1;
            }
            long fn = -1;
            try
            {
                fn =  new RedPillRefrance.RedPillClient().FibonacciNumber(n);
            }
            catch (Exception)
            {
                //log
            }
            return fn;
        }

        /// <summary>
        /// will reverse a given string 
        /// example :   "asdf" will be "fdsa"
        /// </summary>
        /// <param name="s">the string to be reverced</param>
        /// <returns>
        /// reversed string
        /// </returns>
        public string ReverseWords(string s)
        {
            string rw = string.Empty;
            try
            {
                rw =  new RedPillRefrance.RedPillClient().ReverseWords(s);
            }
            catch (Exception)
            {
                //will return string.empty
            }
            return rw;
        }

        /// <summary>
        /// calles my token
        /// </summary>
        /// <returns>Get My token</returns>
        public Guid WhatIsYourToken()
        {
            return new Guid("9cf64c48-485e-47cc-9cc2-d1221fbb1b2d");
        }

        /// <summary>
        /// get the type of the triangle based on its edgs length
        /// </summary>
        /// <param name="a">first edg</param>
        /// <param name="b">secound edg</param>
        /// <param name="c">thired edg</param>
        /// <returns></returns>
        public KnockKnock.RedPillRefrance.TriangleType WhatShapeIsThis(int a, int b, int c)
        {

            return new RedPillRefrance.RedPillClient().WhatShapeIsThis(a, b, c);

        }




    }
}
