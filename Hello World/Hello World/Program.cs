using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            string name = "Trish";
            
            Console.WriteLine($"My name is {name}");
            Console.WriteLine("Write me a message: ");
            
            string inputReadLine = Console.ReadLine();
            
            Console.WriteLine($"This is what you typed: {inputReadLine}");  
            Console.ReadLine();
        }
    }
}
