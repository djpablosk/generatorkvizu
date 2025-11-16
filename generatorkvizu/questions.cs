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
            string answerLine = File.ReadAllText(way1).LastOrDefault().ToString();
            Console.WriteLine(answerLine);
        }
       
        public void loadQuestion2()
        {
            string[] question2 = File.ReadAllLines(way2);
            for (int i = 0; i < 6; i++)
            {
                if (i < question2.Length)
                {
                    Console.WriteLine(question2[i]);
                }
                else
                {
                    break;
                }
            }
        }
        public void LoadAnswer2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            string answerLine2 = File.ReadAllLines(way2).LastOrDefault().ToString();
            Console.WriteLine(answerLine2);
        }
    }
}
