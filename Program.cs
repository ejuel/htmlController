using System;
using System.Threading;
//using System.Windows.Forms
namespace htmlController
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            while (true)
            {
                Thread.Sleep(10000);
                Console.WriteLine(DateTime.Now.ToString("F"));
                //object.SendKeys.
            }
        }
    }
}
