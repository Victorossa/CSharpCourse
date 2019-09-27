using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_ReadingAndWritingToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleased enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Hola {0}",name);
            Console.ReadLine();
        }
    }
}

//Reading from the console
//Writing to the console
//2 ways to write to console (ways - formas)
//  Concatenation and place holder syntax - most prefered (place hoder - marcador)
//although there are other methods to write to the console (aun que existen otros metodos)
