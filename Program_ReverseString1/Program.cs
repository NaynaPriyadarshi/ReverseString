using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_ReverseString1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Word = "a b c d e f";
            for(int i= Word.Length-1; i>=0; i--)
            {
                Console.WriteLine(Word[i] + "");

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
