using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message); // Signature (void) and (string Message);

    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            // A delegate is a type safe function pointer

            del("Hello from Delegate");

            Console.ReadKey();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }
}
