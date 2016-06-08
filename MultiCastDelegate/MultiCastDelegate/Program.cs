using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multicast delegate is a delegate that has references to more than one function.
            //SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            //SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
            //SampleDelegate del3 = new SampleDelegate(SampleMethodThree);
            //SampleDelegate del4 = del1 + del2 + del3;
            //del4();

            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            del1 += SampleMethodTwo;
            del1 += SampleMethodThree;

            del1();
            Console.ReadKey();
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample 1 invoked");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample 2 invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample 3 invoked");
        }

    }

    public delegate void SampleDelegate();
}
