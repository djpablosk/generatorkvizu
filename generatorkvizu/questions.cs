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

        public void loadQuestion1()
        {
            string[] lines = File.ReadAllLines(way1);

            for (int i =0; i < 6; i++)
            {
               if (i < lines.Length)
                {
                    Console.WriteLine(lines[i]);
                }
               else
                {
                    break;
                }
            }
        }  
        public void LoadAnswer1()
        {
            string answerLine = File.ReadAllText(way2);
            
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
