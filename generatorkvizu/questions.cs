using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorkvizu
{
    internal class questions
    {
        private const string way = @"C:\Users\smrzo\Documents\projekty VisualStudio\kviz\1.txt";

        public  void  loadQuestion1()
            {
             string question1 = File.ReadAllLines(way)[0];
            Console.WriteLine(question1);

            }
        public void LoadAnswer1()
        {
            string answer1 = File.ReadAllLines(way)[6];
            Console.WriteLine(answer1);
        }

        
    }
}
