using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Common;

namespace EFCore.FullFxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application start");

            var app = new Application();
            app.Run().Wait();

            Console.WriteLine("Application end");
            Console.ReadLine();
        }
    }
}
