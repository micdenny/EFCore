using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Common;

namespace EFCore.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Application start");

            var app = new Application();
            app.Run().Wait();

            Console.WriteLine("Application end");
            Console.ReadLine();
        }
    }
}
