using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HeyService.KnockService;

namespace HeyService
{

    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/System")]
    public class ArgumentOutOfRangeException
    {
        private string _mpi;

        ///<summary>
        /// Gets or sets the MPI.
        ///</summary>
        [DataMember]
        public string Mpi
        {
            get { return _mpi; }
            set { _mpi = value; }
        }
    }
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/System")]
    public class ArgumentNullException
    {
        private string _mpi;

        ///<summary>
        /// Gets or sets the MPI.
        ///</summary>
        [DataMember]
        public string Mpi
        {
            get { return _mpi; }
            set { _mpi = value; }
        }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyService : IRedPill
    {
        //public TriangleType Triangle;
        
        public static knockknock.readify.net.TriangleType GetTriangleType(int a, int b, int c)
        {
            //Placing items in an array for processing 
            int[] values = new int[3] { a, b, c };

            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return knockknock.readify.net.TriangleType.Error;
            }
            else if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return knockknock.readify.net.TriangleType.Equilateral;
            }
            else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return knockknock.readify.net.TriangleType.Isosceles;
            }
            else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return knockknock.readify.net.TriangleType.Scalene;
            }
            else
            {
                return knockknock.readify.net.TriangleType.Error;
            }
        }
        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        
        public WhatIsYourTokenResponse WhatIsYourToken(WhatIsYourTokenRequest request)
        {
            WhatIsYourTokenResponse res = new WhatIsYourTokenResponse(new Guid("1122668f-8dd4-414b-93a5-81400dcff849"));
            return res;
        }

        public FibonacciNumberResponse FibonacciNumber(FibonacciNumberRequest request)
        {
            FibonacciNumberResponse res = null;
            try
            {
                RedPillClient client = new RedPillClient("BasicHttpBinding_IRedPill");
                res = client.FibonacciNumber(new FibonacciNumberRequest(request.n));
                
                //res = new FibonacciNumberResponse(request.n);
                //string result = string.Empty;
                //foreach (long i in fibonacci(request.n))
                //    result += i.ToString();
                //res.FibonacciNumberResult = Convert.ToInt64(result);
            }  
            catch (Exception ex)
            {
                res.FibonacciNumberResult = request.n;
                //throw new FaultException<ArgumentOutOfRangeException>(new ArgumentOutOfRangeException() { Mpi = "n is out of range." + ex.ToString() + ex.Message }, new FaultReason("n is out of range." + ex.ToString() + ex.Message));
                //throw new ArgumentOutOfRangeException("n is out of range");
            }
            return res;
        }
        private static long GetNegativeFibonacci_Rec(long n)
        {
            if ((n == 0) || (n == -1))
            {
                return Math.Abs(n);
            }
            else
                return GetNegativeFibonacci_Rec(n + 2) - GetNegativeFibonacci_Rec(n + 1);
        }
        private static long GetNthFibonacci_Rec(long n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
        }
        private static long[] fibonacci(long limit)
        {
            long[] series = new long[1];
            Array.Resize(ref series, Convert.ToInt32(Math.Abs(limit)));

            series[0] = 0;
            series[1] = 1;

            for (long i = 2; i < limit; i++)
                series[i] = series[i - 1] + series[i - 2];

            return series;
        }

        public WhatShapeIsThisResponse WhatShapeIsThis(WhatShapeIsThisRequest request)
        {   
            int a = request.a;
            int b = request.b;
            int c = request.c;
            WhatShapeIsThisResponse res = new WhatShapeIsThisResponse(MyService.GetTriangleType(a, b, c));
            
            return res;
        }

        public ReverseWordsResponse ReverseWords(ReverseWordsRequest request)
        {
            ReverseWordsResponse res = null;
            try
            {
                char[] arr = request.s.ToCharArray();
                Array.Reverse(arr);
                res = new ReverseWordsResponse(new string(arr));
            }
            catch (NullReferenceException)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException() { Mpi = "s is null" },new FaultReason("s is null"));
                //throw new ArgumentNullException("s is null");
                //res = new ReverseWordsResponse("s is null");
            }
            return res;
        }
    }
}
