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

        public bool loadQuestion1()
        {
            string question1 = File.ReadAllText(way);
            Console.WriteLine(question1);
            return true;
        }  
        public void LoadAnswer1()
        {
            string answer1 = "3";
            Console.WriteLine(answer1);
        }
       
        
    }
}
