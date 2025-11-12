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
            Console.ReadKey();
            Console.Clear();
        }
    }
}
