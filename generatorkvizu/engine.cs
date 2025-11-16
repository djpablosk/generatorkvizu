using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorkvizu
{
    internal class engine
    {
      public void begin()
        {
            Console.WriteLine("Vitaj v Generatore  kvizov");
            Thread.Sleep(500);
            Console.WriteLine("Pre spustenie kvizu stlac ENTER");
            Console.ReadLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void end()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Kviz skonceny, dakujem za pouzivanie");
            Thread.Sleep(500);
            Console.WriteLine("Vytvoril Patrik Smržo");
        }

    }
}
