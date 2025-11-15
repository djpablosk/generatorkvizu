using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorkvizu
{
    internal class questions
    {
        private const string way1 = @"C:\Users\smrzo\Documents\projekty VisualStudio\kviz\1.txt";
        private const string way2 = @"C:\Users\smrzo\Documents\projekty VisualStudio\kviz\2.txt";

        public bool loadQuestion1()
        {
            string question1 = File.ReadAllText(way1);
            Console.WriteLine(question1);
            return true;
        }  
        public void LoadAnswer1()
        {
            string answer1 = "3";
            Console.WriteLine($"Spravna odpoved je: {answer1}");
        }
       
        public bool loadQuestion2()
        {
            string question2 = File.ReadAllText(way2);
            Console.WriteLine(question2);
            return true;
        }
        public void LoadAnswer2()
        {
            string answer2 = @"Fuha mas to zle spravna odpoved je 'E'
A to je Fernando Alonso";
            Console.WriteLine($"Spravna odpoved je: {answer2}");
        }
    }
}
